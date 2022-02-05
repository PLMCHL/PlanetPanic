using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class GameSessionManager : MonoBehaviour
{
    private const int PLAYER_COUNT = 2;
    private Vector3Int START_POSITION = new Vector3Int(0, 0, 0);

    private List<Vector3Int> DIRECTIONS = new List<Vector3Int>
    {
        new Vector3Int(0, -1, 1),
        new Vector3Int(1, -1, 0),
        new Vector3Int(1, 0, -1),
        new Vector3Int(0, 1, -1),
        new Vector3Int(-1, 1, 0),
        new Vector3Int(-1, 0, 1)
    };

    public Tilemap directionMap;
    public Tilemap orbMap;

    private int movementsLeft = 0;
    private int? directionSelected = null;

    private PlayerManager playerManager;
    private GameInterfaceManager gameInterfaceManager;

    private LineRenderer lineRenderer;

    public State state { get; private set; }
    public enum State
    {
        Rolling,
        Moving,
        DirectionSelect,
        Waiting
    }

    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);

        InitializePlayers();
        InitializeGameInterface();

        DiceRoller.Instance.StartRoll();
        state = State.Rolling;

        // Create line
        lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = 2;
        lineRenderer.useWorldSpace = true;
    }

    void Update()
    {
        // TODO: Select direction with arrows
        if (state == State.DirectionSelect)
        {
            var currentPlayer = playerManager.GetCurrentPlayer();

            var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);
            HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

            // TODO ask for selection from these
            var selectedDirection = directionTile.directions[directionSelected.Value];

            var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + 2 * DIRECTIONS[selectedDirection];

            var directionTarget = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

            // Display directional line
            lineRenderer.enabled = true;

            // TODO clean up
            var translation = new Vector3(0, 0, -2);
            lineRenderer.SetPosition(0, currentPlayer.transform.position + translation);
            lineRenderer.SetPosition(1, directionTarget + translation);

            // Select direction
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // TODO hide selection arrow

                state = State.Moving;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                directionSelected = (directionSelected + 1 ) % directionTile.directions.Count;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                directionSelected = ((directionSelected - 1) + directionTile.directions.Count) % directionTile.directions.Count;
            }
        }
        else if (state == State.Moving)
        {
            var completed = MoveCurrentPlayer();

            // If there are no movements left, stop the player and wait to end turn
            if (movementsLeft == 0)
            {
                // Grant player an orb when falling on space
                var newPos = directionMap.WorldToCell(playerManager.GetCurrentPlayer().transform.position);
                HexOrbTile orbTile = (HexOrbTile)orbMap.GetTile(newPos);
                Debug.Log("ORB TYPE: " + orbTile.orbType.ToString());

                playerManager.GetCurrentPlayer().GetComponent<PlayerInfo>().AddScore(orbTile.orbType, 1);

                state = State.Waiting;
            }
        }
        else if (state == State.Rolling)
        {
            // When pressed use selection and advance
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var diceValue = DiceRoller.Instance.GetValue();

                movementsLeft = diceValue;

                state = State.Moving;
            }
        }
        else if (state == State.Waiting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Switch User
                playerManager.EndPlayerTurn();

                DiceRoller.Instance.StartRoll();
                state = State.Rolling;
            }
        }

        gameInterfaceManager.UpdateInterface();
    }

    private bool MoveCurrentPlayer()
    {
        var currentPlayer = playerManager.GetCurrentPlayer();

        var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);

        HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

        // Ask for selection if there is more than 1 direction
        int direction;
        if (directionTile.directions.Count > 1) {

            if (!directionSelected.HasValue)
            {
                state = State.DirectionSelect;
                directionSelected = 0;
                return false;
            }

            lineRenderer.enabled = false;

            direction = directionTile.directions[directionSelected.Value];
            directionSelected = null;
        }
        else
        {
            direction = directionTile.directions[0];
        }

        //var direction = directionTile.directions[Random.Range(0, directionTile.directions.Count)];

        var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[direction];

        currentPlayer.transform.position = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

        movementsLeft--;

        return true;
    }

    private void InitializePlayers()
    {
        playerManager = PlayerManager.Instance;
        playerManager.Initialize(PLAYER_COUNT, START_POSITION);
        playerManager.SetCurrentPlayerIndex(0);
    }

    private void InitializeGameInterface()
    {
        gameInterfaceManager = GameInterfaceManager.Instance;
        gameInterfaceManager.Initialize();
    }

}
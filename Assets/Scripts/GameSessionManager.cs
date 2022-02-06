using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameSessionManager : MonoBehaviour
{
    private const int PLAYER_COUNT = 2;
    private Vector3Int START_POSITION = new Vector3Int(0, 0, 0);

    public static List<Vector3Int> DIRECTIONS = new List<Vector3Int>
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

    private int turnNumber = 0;
    private int movementsLeft = 0;

    private PlayerManager playerManager;
    private GameInterfaceManager gameInterfaceManager;

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
    }

    void Update()
    {
        // TODO: Select direction with arrows
        if (state == State.DirectionSelect)
        {
            // Select direction
            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.Moving;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                DirectionSelectorManager.Instance.IncrementSelection(1);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                DirectionSelectorManager.Instance.IncrementSelection(1);
            }

            var currentPlayer = playerManager.GetCurrentPlayer();
            DirectionSelectorManager.Instance.UpdateSelector(directionMap, currentPlayer);
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
                // End turn, Switch User
                turnNumber++;
                playerManager.EndPlayerTurn();

                DiceRoller.Instance.StartRoll();
                state = State.Rolling;
            }
        }

        gameInterfaceManager.UpdateInterface(turnNumber/PLAYER_COUNT);
    }

    private bool MoveCurrentPlayer()
    {
        var currentPlayer = playerManager.GetCurrentPlayer();

        var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);

        HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

        // Ask for selection if there is more than 1 direction
        int direction;
        if (directionTile.directions.Count > 1) {

            if (!DirectionSelectorManager.Instance.Active())
            {
                DirectionSelectorManager.Instance.StartSelection(directionMap, currentPlayer);
                state = State.DirectionSelect;
                return false;
            }

            direction = DirectionSelectorManager.Instance.CompleteSelection();
        }
        else
        {
            direction = directionTile.directions[0];
        }

        var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[direction];

        currentPlayer.transform.position = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

        movementsLeft--;
        DiceRoller.Instance.SetValue(movementsLeft);

        // Add short wait, to make it easier to follow
        Thread.Sleep(200);

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
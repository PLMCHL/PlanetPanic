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

    private PlayerManager playerManager;
    private GameInterfaceManager gameInterfaceManager;

    public State state { get; private set; }
    public enum State
    {
        Rolling,
        Wait
    }

    void Start()
    {
        UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);

        InitializePlayers();
        InitializeGameInterface();

        DiceRoller.Instance.StartRoll();
        state = State.Rolling;
    }

    void Update()
    {
        // TODO: Select direction with arrows
        if (state == State.Rolling)
        {
            // When pressed use selection and advance
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var diceValue = DiceRoller.Instance.GetValue();

                var newPos = MoveCurrentPlayer(diceValue);

                // Grant player an orb when falling on space
                HexOrbTile orbTile = (HexOrbTile)orbMap.GetTile(CubeCoordUtils.CubeToUnityCell(newPos));
                Debug.Log("ORB TYPE: " + orbTile.orbType.ToString());

                playerManager.GetCurrentPlayer().GetComponent<PlayerInfo>().AddScore(orbTile.orbType, 1);

                state = State.Wait;
            }
        } 
        else if (state == State.Wait)
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

    private Vector3Int MoveCurrentPlayer(int spaces)
    {
        Vector3Int newPos = new Vector3Int(0, 0, 0);
        var currentPlayer = playerManager.GetCurrentPlayer();

        for (int i = 0; i < spaces; i++)
        {
            var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);

            HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

            var direction = directionTile.directions[Random.Range(0, directionTile.directions.Count)];

            newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[direction];

            currentPlayer.transform.position = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));
        }

        return newPos;
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
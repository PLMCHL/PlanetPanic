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

    void Start()
    {
        UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);

        InitializePlayers();
        InitializeGameInterface();
    }

    void Update()
    {
        // TODO: Select direction with arrows

        // When pressed use selection and advance
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get current position and move player
            var currentPlayer = playerManager.GetCurrentPlayer();

            var gridPosition = directionMap.WorldToCell(currentPlayer.transform.position);

            Debug.Log("GRID POSITION: " + gridPosition);
            HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

            var direction = directionTile.directions[Random.Range(0, directionTile.directions.Count)];

            var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[direction];

            Debug.Log("NEW GRID POSITION: " + newPos);

            currentPlayer.transform.position = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

            // Grant player an orb when falling on space
            HexOrbTile orbTile = (HexOrbTile)orbMap.GetTile(CubeCoordUtils.CubeToUnityCell(newPos));
            Debug.Log("ORB TYPE: " + orbTile.orbType.ToString());

            playerManager.GetCurrentPlayer().GetComponent<PlayerInfo>().AddScore(orbTile.orbType, 1);

            // Switch User
            playerManager.EndPlayerTurn();
        }

        gameInterfaceManager.UpdateInterface();
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

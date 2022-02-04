using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
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
    private GameObject player;

    void Start()
    {
        this.player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        // TODO Selection of the direction

        // When pressed use selection and advance
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var gridPosition = directionMap.WorldToCell(player.transform.position);

            Debug.Log("GRID POSITION: " + gridPosition);
            HexDirectionalTile directionTile = (HexDirectionalTile)directionMap.GetTile(gridPosition);

            var direction = directionTile.directions[Random.Range(0, directionTile.directions.Count)];

            var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[direction];

            Debug.Log("NEW GRID POSITION: " + newPos);

            this.player.transform.position = directionMap.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));

            // TODO grant player an orb when falling on space
            HexOrbTile orbTile = (HexOrbTile)orbMap.GetTile(CubeCoordUtils.CubeToUnityCell(newPos));
            Debug.Log("ORB TYPE: " + orbTile.orbType.ToString());
        }
    }

}

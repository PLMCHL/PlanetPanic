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

    public Tilemap map;
    private GameObject player;

    void Start()
    {
        this.player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var gridPosition = map.WorldToCell(player.transform.position);

            Debug.Log("GRID POSITION: " + gridPosition);
            HexDirectionalTile tile = (HexDirectionalTile)map.GetTile(gridPosition);

            Debug.Log("DIRECTION: " + tile.directions);

            // TODO fix
            var newPos = CubeCoordUtils.UnityCellToCube(gridPosition) + DIRECTIONS[tile.directions[0]];

            Debug.Log("NEW GRID POSITION: " + newPos);

            this.player.transform.position = map.CellToWorld(CubeCoordUtils.CubeToUnityCell(newPos));
        }
    }

}

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
            DirectionalTile tile = (DirectionalTile)map.GetTile(gridPosition);

            Debug.Log("DIRECTION: " + tile.direction);

            var newPos = UnityCellToCube(gridPosition) + DIRECTIONS[tile.direction];

            Debug.Log("NEW GRID POSITION: " + newPos);

            this.player.transform.position = map.CellToWorld(CubeToUnityCell(newPos));
        }
    }

    private Vector3Int UnityCellToCube(Vector3Int cell)
    {
        var yCell = cell.x;
        var xCell = cell.y;
        var x = yCell - (xCell - (xCell & 1)) / 2;
        var z = xCell;
        var y = -x - z;
        return new Vector3Int(x, y, z);
    }

    private Vector3Int CubeToUnityCell(Vector3Int cube)
    {
        var x = cube.x;
        var z = cube.z;
        var col = x + (z - (z & 1)) / 2;
        var row = z;

        return new Vector3Int(col, row, 0);
    }
}

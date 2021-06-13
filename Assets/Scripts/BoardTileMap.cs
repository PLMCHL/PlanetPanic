using System.Collections.Generic;
using UnityEngine;

class BoardTileMap
{
    private List<int> tileDirectionList = new List<int> { 0, 5, 5, 0, 1, 0, 5, 5, 0, 1, 0, 1, 1, 2, 3, 3, 2, 1, 2, 2, 3, 3, 4, 5, 4, 3, 4, 4 };

    private List<Vector3Int> DIRECTIONS = new List<Vector3Int>
    {
        new Vector3Int(0, -1, 1),
        new Vector3Int(1, -1, 0),
        new Vector3Int(1, 0, -1),
        new Vector3Int(0, 1, -1),
        new Vector3Int(-1, 1, 0),
        new Vector3Int(-1, 0, 1)
    };

    public TileNode launch { get; private set; }
    public TileNode start { get; private set; }

    public BoardTileMap(Vector3Int launch)
    {
        this.launch = new TileNode(launch);
        InitializeTiles();
    }

    void InitializeTiles()
    {
        var currTile = launch;

        foreach (var dir in tileDirectionList)
        {
            var nextTile = new TileNode(currTile.Location + DIRECTIONS[dir]);

            if (start == null)
            {
                start = nextTile;
            }

            currTile.nextTiles = new List<TileNode> { nextTile };

            currTile = nextTile;
        }
    }
}
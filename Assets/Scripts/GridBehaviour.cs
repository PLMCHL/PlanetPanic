using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridBehaviour : MonoBehaviour
{
    public TileBase grass;
    public TileBase dirt;
    public TileBase lava;
    public TileBase magic;
    public TileBase rock;
    public TileBase sand;

    public Tilemap tileMap;

    private BoardTileMap boardTileMap = new BoardTileMap(new Vector3Int(0, 0, 0));

    // Start is called before the first frame update
    void Start()
    {
        SetTilesPath();
    }

    void SetTilesPath()
    {
        setTile(boardTileMap.launch.Location, sand);

        recursiveFill(new List<TileNode>{ boardTileMap.start });
    }

    void recursiveFill(List<TileNode> tiles)
    {
        if (tiles == null)
        {
            return;
        }
            
        foreach(TileNode tile in tiles)
        {
            setTile(tile.Location, grass);

            recursiveFill(tile.nextTiles);
        }
    }

    private Vector3Int CubeToUnityCell(Vector3Int cube)
    {
        var x = cube.x;
        var z = cube.z;
        var col = x + (z - (z & 1)) / 2;
        var row = z;

        return new Vector3Int(col, row, 0);
    }

    private void setTile(Vector3Int loc, TileBase tileType)
    {
        tileMap.SetTile(CubeToUnityCell(loc), tileType);
    }
}

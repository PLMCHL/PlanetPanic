using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridMap : MonoBehaviour
{
    //private List<int> tileDirectionList = new List<int> { 1, 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 2, 3, 3, 4, 4, 5, 5, 5 };
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

    public TileBase grass;
    public TileBase dirt;
    public TileBase lava;
    public TileBase magic;
    public TileBase rock;
    public TileBase sand;

    public Tilemap tileMap;

    // Start is called before the first frame update
    void Start()
    {
        //SetTilesAroundChar();
        //SetTilesAroundCharCube();
        //SetTilesAroundCharDirectionsCube();
        SetTilesPath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SetTilesAroundChar()
    {
        tileMap.SetTile(new Vector3Int(0, 1, 0), dirt);
        tileMap.SetTile(new Vector3Int(1, 0, 0), lava);
        tileMap.SetTile(new Vector3Int(0, -1, 0), magic);
        tileMap.SetTile(new Vector3Int(-1, -1, 0), sand);
        tileMap.SetTile(new Vector3Int(-1, 0, 0), rock);
        tileMap.SetTile(new Vector3Int(-1, 1, 0), grass);
    }

    void SetTilesAroundCharCube()
    {
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(0, -1, 1)), dirt);
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(1, -1, 0)), lava);
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(1, 0, -1)), magic);
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(0, 1, -1)), sand);
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(-1, 1, 0)), rock);
        tileMap.SetTile(CubeToUnityCell(new Vector3Int(-1, 0, 1)), grass);
    }

    private Vector3Int CubeToUnityCell(Vector3Int cube)
    {
        var x = cube.x;
        var z = cube.z;
        var col = x + (z - (z & 1)) / 2;
        var row = z;

        return new Vector3Int(col, row, 0);
    }

    void SetTilesAroundCharDirectionsCube()
    {
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[0]), dirt);
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[1]), lava);
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[2]), magic);
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[3]), sand);
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[4]), rock);
        tileMap.SetTile(CubeToUnityCell(DIRECTIONS[5]), grass);
    }

    void SetTilesPath()
    {
        var loc = new Vector3Int(0, 0, 0);
        tileMap.SetTile(loc, sand);

        foreach (var dir in tileDirectionList)
        {
            loc = loc + DIRECTIONS[dir];

            tileMap.SetTile(CubeToUnityCell(loc), grass);
        }        
    }
}

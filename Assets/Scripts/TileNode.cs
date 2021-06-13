using System.Collections.Generic;
using UnityEngine;

class TileNode
{
    public int x;
    public int y;
    public int z;

    public List<TileNode> nextTiles;

    public TileNode(Vector3Int start)
    {
        this.x = start.x;
        this.y = start.y;
        this.z = start.z;
    }

    public Vector3Int Location { get
        {
            return new Vector3Int(x, y, z);
        }
    }
}
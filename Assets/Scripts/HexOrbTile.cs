using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public partial class HexOrbTile : Tile
{
    public OrbTypes orbType;

    [CreateTileFromPalette]
    public static TileBase CreateOrbTile(Sprite sprite)
    {
        var tClass = ScriptableObject.CreateInstance<HexOrbTile>();
        tClass.sprite = sprite;
        tClass.name = sprite.name;
        return tClass;
    }
}

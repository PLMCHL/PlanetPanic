using UnityEngine;
using UnityEngine.Tilemaps;

#if UNITY_EDITOR
using UnityEditor.Tilemaps;
#endif

public partial class HexOrbTile : Tile
{
    public OrbTypes orbType;

#if UNITY_EDITOR
    [CreateTileFromPalette]
    public static TileBase CreateOrbTile(Sprite sprite)
    {
        var tClass = ScriptableObject.CreateInstance<HexOrbTile>();
        tClass.sprite = sprite;
        tClass.name = sprite.name;
        return tClass;
    }
#endif
}

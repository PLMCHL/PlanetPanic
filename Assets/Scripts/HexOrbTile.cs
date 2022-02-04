using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HexOrbTile : Tile
{
    public enum OrbTypes { Ice, Mud, Forest, Poison, Sand };

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

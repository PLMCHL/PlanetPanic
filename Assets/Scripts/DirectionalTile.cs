using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DirectionalTile : Tile
{
    public int direction;

    [CreateTileFromPalette]
    public static TileBase CreateDirectionalTile(Sprite sprite)
    {
        var tClass = ScriptableObject.CreateInstance<DirectionalTile>();
        tClass.sprite = sprite;
        tClass.name = sprite.name;
        return tClass;
    }
}

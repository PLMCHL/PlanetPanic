using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HexDirectionalTile : Tile
{
    public List<int> directions;

    public override bool StartUp(Vector3Int location, ITilemap tilemap, GameObject go)
    {
        SpriteManagerBehaviour spriteManager = (SpriteManagerBehaviour)FindObjectOfType(typeof(SpriteManagerBehaviour));

        // TODO combine directions instead
        foreach (int direction in directions)
        {
            switch (direction)
            {
                case 0:
                    this.sprite = spriteManager.UpRightSprite;
                    break;
                case 1:
                    this.sprite = spriteManager.RightSprite;
                    break;
                case 2:
                    this.sprite = spriteManager.DownRightSprite;
                    break;
                case 3:
                    this.sprite = spriteManager.DownLeftSprite;
                    break;
                case 4:
                    this.sprite = spriteManager.LeftSprite;
                    break;
                case 5:
                    this.sprite = spriteManager.UpLeftSprite;
                    break;
            }
        }
        
        return true;
    }

    [CreateTileFromPalette]
    public static TileBase CreateDirectionalTile(Sprite sprite)
    {
        var tClass = ScriptableObject.CreateInstance<HexDirectionalTile>();
        tClass.sprite = sprite;
        tClass.name = sprite.name;
        return tClass;
    }


}

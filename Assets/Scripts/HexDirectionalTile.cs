using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HexDirectionalTile : Tile
{
    public List<int> directions;

    public override bool StartUp(Vector3Int location, ITilemap tilemap, GameObject go)
    {
        if (directions == null)
        {
            return false;
        }

        SpriteManagerBehaviour spriteManager = (SpriteManagerBehaviour)FindObjectOfType(typeof(SpriteManagerBehaviour));

        List<Sprite> directionSprites = new List<Sprite>();

        foreach (int direction in directions)
        {
            switch (direction)
            {
                case 0:
                    directionSprites.Add(spriteManager.UpRightSprite);
                    break;
                case 1:
                    directionSprites.Add(spriteManager.RightSprite);
                    break;
                case 2:
                    directionSprites.Add(spriteManager.DownRightSprite);
                    break;
                case 3:
                    directionSprites.Add(spriteManager.DownLeftSprite);
                    break;
                case 4:
                    directionSprites.Add(spriteManager.LeftSprite);
                    break;
                case 5:
                    directionSprites.Add(spriteManager.UpLeftSprite);
                    break;
            }
        }

        this.sprite = spriteManager.getDirectionCombo(directionSprites.ToArray());

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

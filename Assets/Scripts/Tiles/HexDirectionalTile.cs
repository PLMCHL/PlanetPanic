using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

#if UNITY_EDITOR
using UnityEditor.Tilemaps;
#endif

public class HexDirectionalTile : Tile
{
    public List<int> directions;

    public override void GetTileData(Vector3Int location, ITilemap tilemap, ref TileData tileData)
    {
        tileData.sprite = GetSpriteCombo();
    }

    private Sprite GetSpriteCombo()
    {
        if (directions == null)
        {
            return null;
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

        return spriteManager.getDirectionCombo(directionSprites.ToArray());
    }

#if UNITY_EDITOR
    [CreateTileFromPalette]
    public static TileBase CreateDirectionalTile(Sprite sprite)
    {
        var tClass = ScriptableObject.CreateInstance<HexDirectionalTile>();
        tClass.sprite = sprite;
        tClass.name = sprite.name;
        return tClass;
    }
#endif
}

using System;
using UnityEngine;

public class SpriteManagerBehaviour : MonoBehaviour
{
    public Sprite UpRightSprite;
    public Sprite RightSprite;
    public Sprite DownRightSprite;
    public Sprite DownLeftSprite;
    public Sprite LeftSprite;
    public Sprite UpLeftSprite;

    public Sprite getDirectionCombo(params Sprite[] sprites)
    {
        if (sprites.Length < 1)
        {
            return null;
        }

        // Always assume the sprites are the same size
        Texture2D texture = new Texture2D(sprites[0].texture.width, sprites[0].texture.height);
        texture.filterMode = FilterMode.Point;
        texture.wrapMode = TextureWrapMode.Clamp;

        for (int x = 0; x < texture.width; x++)
        {
            for (int y = 0; y < texture.height; y++)
            {
                var newColor = new Color32(0, 0, 0, 0);

                foreach (Sprite sprite in sprites)
                {
                    var pixel = sprite.texture.GetPixel(x, y);

                    // Don't replace if the pixel is transparent
                    // If any sprites collide, the last one always wins
                    if (pixel.a != 0)
                    {
                        newColor = pixel;
                    }
                }

                texture.SetPixel(x, y, newColor);
            }
        }

        texture.Apply();

        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f)); ;

    }
}

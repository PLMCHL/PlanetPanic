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

    public Sprite getDirectionCombo(params Sprite[] values)
    {
        // TODO reuse sprites

        if (values.Length == 1)
        {
            return values[0];
        }

        return mergeSprites(values[0], values[1]);
    }

    private Sprite mergeSprites(Sprite s1, Sprite s2)
    {
        // TODO extend to accept array

        var t1 = s1.texture;
        var t2 = s2.texture;

        Texture2D texture = new Texture2D(t1.width, t1.height);
        texture.filterMode = FilterMode.Point;
        texture.wrapMode = TextureWrapMode.Clamp;

        for (int x = 0; x < texture.width; x++)
        {
            for (int y = 0; y < texture.height; y++)
            {
                var newColor = new Color32(0, 0, 0, 0);

                var p1 = s1.texture.GetPixel(x, y);
                if (p1.a != 0)
                {
                    newColor = p1;
                }

                var p2 = s2.texture.GetPixel(x, y);
                if (p2.a != 0)
                {
                    newColor = p2;
                }

                texture.SetPixel(x, y, newColor);
            }
        }

        texture.Apply();

        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f)); ;

    }
}

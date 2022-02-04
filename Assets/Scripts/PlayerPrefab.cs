using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    public static int LastUsedIndex = 0;
    public List<Sprite> sprites;

    void Start()
    {
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[LastUsedIndex++];
    }
}

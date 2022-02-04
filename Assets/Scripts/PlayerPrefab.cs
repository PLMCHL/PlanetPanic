using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    public static int LastUsedIndex;
    public List<Sprite> sprites;

    private static bool initialized;

    void Awake()
    {
        if (!initialized)
        {
            LastUsedIndex = Random.Range(0, sprites.Count);
            initialized = true;
        }

        // Set player sprite
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[LastUsedIndex++];
    }
}

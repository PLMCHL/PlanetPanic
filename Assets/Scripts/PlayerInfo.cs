using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static int LastUsedIndex;
    public List<Sprite> sprites;
    public Dictionary<OrbTypes, int> orbScores;

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

        // Set player scores
        orbScores = new Dictionary<OrbTypes, int> {
            [OrbTypes.Ice] = 0,
            [OrbTypes.Mud] = 0,
            [OrbTypes.Forest] = 0,
            [OrbTypes.Poison] = 0,
            [OrbTypes.Sand] = 0
        };
    }

    public void AddScore(OrbTypes type, int score)
    {
        orbScores[type] += score;
    }
}

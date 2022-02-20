using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    private static int LastUsedSpriteIndex;
    private static int LastUsedKeyCodeIndex;

    private KeyCode[] KEY_CODES = { KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B };
    public List<Sprite> sprites;

    public Dictionary<OrbTypes, int> playerOrbScore;
    private KeyCode playerKeyCode;

    private static bool initialized;

    void Awake()
    {
        if (!initialized)
        {
            LastUsedSpriteIndex = Random.Range(0, sprites.Count);
            LastUsedKeyCodeIndex = 0;
            initialized = true;
        }

        // Set player key
        playerKeyCode = KEY_CODES[LastUsedKeyCodeIndex++];
        LastUsedKeyCodeIndex = LastUsedKeyCodeIndex % KEY_CODES.Length;

        // Set player sprite
        var spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[LastUsedSpriteIndex++];
        LastUsedSpriteIndex = LastUsedSpriteIndex % sprites.Count;

        // Set player scores
        playerOrbScore = new Dictionary<OrbTypes, int> {
            [OrbTypes.Ice] = 0,
            [OrbTypes.Mud] = 0,
            [OrbTypes.Forest] = 0,
            [OrbTypes.Poison] = 0,
            [OrbTypes.Sand] = 0
        };
    }

    public void AddScore(OrbTypes type, int score)
    {
        playerOrbScore[type] += score;
    }

    public KeyCode GetPlayerKeyCode()
    {
        return playerKeyCode;
    }
}

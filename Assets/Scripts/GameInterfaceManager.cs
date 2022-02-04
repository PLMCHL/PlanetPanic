using System;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfaceManager : MonoBehaviour
{
    public Image currentPlayerImage;

    private static GameInterfaceManager instance;

    public static GameInterfaceManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameInterfaceManager>();
            }
            return instance;
        }
    }

    public void UpdateInterface()
    {
        // Update current player sprite
        currentPlayerImage.sprite = PlayerManager.Instance.getCurrentPlayer().GetComponent<SpriteRenderer>().sprite;


    }
    internal void Initialize()
    {
        // TODO set up player portrait and info
    }
}

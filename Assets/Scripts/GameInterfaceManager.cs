using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfaceManager : MonoBehaviour
{
    public Image currentPlayerImage;
    public Image PlayerPanelPrefab;

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
        currentPlayerImage.sprite = PlayerManager.Instance.GetCurrentPlayer().GetComponent<SpriteRenderer>().sprite;
    }

    internal void Initialize()
    {
        var playersPanel = this.transform.Find("PlayersPanel");

        var allPlayers = PlayerManager.Instance.GetAllPlayers();

        foreach(var player in allPlayers)
        {
            var playerPanel = Instantiate(PlayerPanelPrefab, PlayerPanelPrefab.transform.position, Quaternion.identity);
            playerPanel.transform.SetParent(playersPanel, false);

            var avatarImage = playerPanel.transform.Find("PlayerImage").GetComponent<Image>();

            //var bbb = player.GetComponent<PlayerPrefab>();
            avatarImage.sprite = player.GetComponent<SpriteRenderer>().sprite;

            //players[i] = playerObj;
        }


        // TODO set up player portrait and info
    }
}

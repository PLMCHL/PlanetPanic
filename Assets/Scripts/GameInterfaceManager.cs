using Assets.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfaceManager : MonoBehaviour
{
    public Image currentPlayerImage;
    public Sprite alienUnknownImage;
    public GameObject PlayerPanelPrefab;

    private static GameInterfaceManager instance;
    private IDictionary<GameObject, GameObject> playerPannelList;

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

        var highScores = new Dictionary<OrbTypes, HighScoreList>();
        highScores.Add(OrbTypes.Ice, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Mud, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Forest, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Poison, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Sand, new HighScoreList(0, null));

        // Update orb scores
        foreach (var (player, panel) in playerPannelList.Select(x => (x.Key, x.Value)))
        {
            UpdatePlayerPanelScore(panel, player, "IceScoreText", OrbTypes.Ice);
            UpdatePlayerPanelScore(panel, player, "MudScoreText", OrbTypes.Mud);
            UpdatePlayerPanelScore(panel, player, "ForestScoreText", OrbTypes.Forest);
            UpdatePlayerPanelScore(panel, player, "PoisonScoreText", OrbTypes.Poison);
            UpdatePlayerPanelScore(panel, player, "SandScoreText", OrbTypes.Sand);

            HighScoreList highScoreList;

            foreach (OrbTypes orbType in Enum.GetValues(typeof(OrbTypes)))
            {
                var playerScore = player.GetComponent<PlayerInfo>().orbScores[orbType];

                highScores.TryGetValue(orbType, out highScoreList);

                if (playerScore > highScoreList.Value)
                {
                    // create a new one and attach
                    highScores[orbType] = new HighScoreList(playerScore, player);
                }
                else if (playerScore == highScoreList.Value && highScoreList.Value != 0)
                {
                    // add to list
                    highScoreList.AddPlayerToList(player);
                }
            }
        }

        UpdateResourcePanelScore(highScores, "IceOwnerIcon", OrbTypes.Ice);
        UpdateResourcePanelScore(highScores, "MudOwnerIcon", OrbTypes.Mud);
        UpdateResourcePanelScore(highScores, "ForestOwnerIcon", OrbTypes.Forest);
        UpdateResourcePanelScore(highScores, "PoisonOwnerIcon", OrbTypes.Poison);
        UpdateResourcePanelScore(highScores, "SandOwnerIcon", OrbTypes.Sand);
    }

    private void UpdatePlayerPanelScore(GameObject panel, GameObject player, string id, OrbTypes type)
    {
        var mudText = panel.transform.Find("OrbScoreContainer/" + id).GetComponent<Text>();
        mudText.text = player.GetComponent<PlayerInfo>().orbScores[type].ToString();
    }

    private void UpdateResourcePanelScore(Dictionary<OrbTypes, HighScoreList> highScores, string id, OrbTypes type)
    {
        // Eval scores and update
        if (highScores[type].GetPlayerList().Count == 1 && highScores[type].Value != 0)
        {
            var ownerImage = this.transform.Find("ResourcePanel/" + id).GetComponent<Image>();
            ownerImage.sprite = highScores[type].GetPlayerList()[0].GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            var ownerImage = this.transform.Find("ResourcePanel/" + id).GetComponent<Image>();
            ownerImage.sprite = alienUnknownImage;
        }
    }

    internal void Initialize()
    {
        playerPannelList = new Dictionary<GameObject, GameObject>();

        var playersPanel = this.transform.Find("PlayersPanel");

        var allPlayers = PlayerManager.Instance.GetAllPlayers();

        // set up player portrait and info
        foreach (var player in allPlayers)
        {
            // Create panel and add to map
            var playerPanel = Instantiate(PlayerPanelPrefab, PlayerPanelPrefab.transform.position, Quaternion.identity);
            playerPanel.transform.SetParent(playersPanel, false);
            playerPannelList.Add(player, playerPanel);

            // Set Panel avatar iamge
            var avatarImage = playerPanel.transform.Find("PlayerImage").GetComponent<Image>();
            avatarImage.sprite = player.GetComponent<SpriteRenderer>().sprite;        }        
    }
}

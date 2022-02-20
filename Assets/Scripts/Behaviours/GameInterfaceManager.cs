using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfaceManager : MonoBehaviour
{
    private int PLAYER_INFO_SIZE_PIXELS = 200;

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

    public void UpdateInterface(int turnNumber)
    {
        UpdateTurnCounter(turnNumber);

        // Update current player sprite
        var currentPlayer = PlayerListManager.Instance.GetCurrentPlayer();
        if (currentPlayer != null)
        {
            currentPlayerImage.sprite = currentPlayer.GetComponent<SpriteRenderer>().sprite;
        }

        if (playerPannelList != null)
        {
            // Update player planel
            foreach (var (player, panel) in playerPannelList.Select(x => (x.Key, x.Value)))
            {
                UpdatePlayerPanelScore(panel, player, "IceScoreText", OrbTypes.Ice);
                UpdatePlayerPanelScore(panel, player, "MudScoreText", OrbTypes.Mud);
                UpdatePlayerPanelScore(panel, player, "ForestScoreText", OrbTypes.Forest);
                UpdatePlayerPanelScore(panel, player, "PoisonScoreText", OrbTypes.Poison);
                UpdatePlayerPanelScore(panel, player, "SandScoreText", OrbTypes.Sand);
            }

            // Update high scores
            var highScores = GetHighScoresList();

            UpdateResourcePanelScore(highScores, "IceOwnerIcon", OrbTypes.Ice);
            UpdateResourcePanelScore(highScores, "MudOwnerIcon", OrbTypes.Mud);
            UpdateResourcePanelScore(highScores, "ForestOwnerIcon", OrbTypes.Forest);
            UpdateResourcePanelScore(highScores, "PoisonOwnerIcon", OrbTypes.Poison);
            UpdateResourcePanelScore(highScores, "SandOwnerIcon", OrbTypes.Sand);
        }
    }

    // TODO move to a better space
    public Dictionary<OrbTypes, HighScoreList> GetHighScoresList()
    {
        var highScores = new Dictionary<OrbTypes, HighScoreList>();

        highScores.Add(OrbTypes.Ice, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Mud, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Forest, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Poison, new HighScoreList(0, null));
        highScores.Add(OrbTypes.Sand, new HighScoreList(0, null));

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
                var playerScore = player.GetComponent<PlayerInfo>().playerOrbScore[orbType];

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

        return highScores;
    }

    public void UpdateTurnCounter(int turnNumber)
    {
        var turnValueObj = this.transform.Find("TurnPanel/TurnValue").GetComponent<Text>();
        turnValueObj.text = turnNumber.ToString();
    }

    private void UpdatePlayerPanelScore(GameObject panel, GameObject player, string id, OrbTypes type)
    {
        var mudText = panel.transform.Find("OrbScoreContainer/" + id).GetComponent<Text>();
        mudText.text = player.GetComponent<PlayerInfo>().playerOrbScore[type].ToString();
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

        var allPlayers = PlayerListManager.Instance.GetAllPlayers();

        // set up player portrait and info
        foreach (var player in allPlayers)
        {
            // Create panel and add to map
            var playerPanel = Instantiate(PlayerPanelPrefab, PlayerPanelPrefab.transform.position, Quaternion.identity);
            playerPanel.transform.SetParent(playersPanel, false);
            playerPannelList.Add(player, playerPanel);

            // Set Panel avatar image
            var avatarImage = playerPanel.transform.Find("PlayerImage").GetComponent<Image>();
            avatarImage.sprite = player.GetComponent<SpriteRenderer>().sprite;

            // Set button value
            var playerKeyCode = player.GetComponent<PlayerInfo>().GetPlayerKeyCode();
            var playerKeyText = playerPanel.transform.Find("PlayerKeyPanel/PlayerKeyText").GetComponent<Text>();
            playerKeyText.text = playerKeyCode.ToString();
        }

        // Adjust size of panel
        RectTransform rt = playersPanel.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(PLAYER_INFO_SIZE_PIXELS * allPlayers.Length, rt.sizeDelta.y);
    }

    public void ShowAnnouncementPanel(String text)
    {
        var announcementPanelCanvasGroup = this.transform.Find("AnnouncementPanel").GetComponent<CanvasGroup>();
        announcementPanelCanvasGroup.alpha = 1;

        var a = this.transform.Find("AnnouncementPanel/AnnouncementText").GetComponent<Text>();
        a.text = text;
    }

    public void HideAnnouncementPanel()
    {
        var announcementPanelCanvasGroup = this.transform.Find("AnnouncementPanel").GetComponent<CanvasGroup>();
        announcementPanelCanvasGroup.alpha = 0;
    }

    public void ClearCurrentPlayer()
    {
        currentPlayerImage.sprite = alienUnknownImage;
    }
}

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfaceManager : MonoBehaviour
{
    public Image currentPlayerImage;
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

        // Update orb scores
        foreach (var (player, panel) in playerPannelList.Select(x => (x.Key, x.Value)))
        {
            var iceText = panel.transform.Find("OrbScoreContainer/IceScoreText").GetComponent<Text>();
            iceText.text = player.GetComponent<PlayerInfo>().orbScores[OrbTypes.Ice].ToString();

            var mudText = panel.transform.Find("OrbScoreContainer/MudScoreText").GetComponent<Text>();
            mudText.text = player.GetComponent<PlayerInfo>().orbScores[OrbTypes.Mud].ToString();

            var forestText = panel.transform.Find("OrbScoreContainer/ForestScoreText").GetComponent<Text>();
            forestText.text = player.GetComponent<PlayerInfo>().orbScores[OrbTypes.Forest].ToString();

            var poisonText = panel.transform.Find("OrbScoreContainer/PoisonScoreText").GetComponent<Text>();
            poisonText.text = player.GetComponent<PlayerInfo>().orbScores[OrbTypes.Poison].ToString();

            var sandText = panel.transform.Find("OrbScoreContainer/SandScoreText").GetComponent<Text>();
            sandText.text = player.GetComponent<PlayerInfo>().orbScores[OrbTypes.Sand].ToString();
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

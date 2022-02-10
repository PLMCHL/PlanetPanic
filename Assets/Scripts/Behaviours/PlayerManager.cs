using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject PlayerPrefab;

    private static PlayerManager instance;

    private int currentPlayerIndex;
    private GameObject[] players;

    public static PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerManager>();
            }
            return instance;
        }
    }

    public void Initialize(int playerCount, Vector3Int startPosition)
    {
        players = new GameObject[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            var playerObj = Instantiate(PlayerPrefab, startPosition, Quaternion.identity);
            players[i] = playerObj;

            // set player object and image
        }
    }

    public void SetCurrentPlayerIndex(int index)
    {
        currentPlayerIndex = index;
    }
    public void EndPlayerTurn()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
    }

    public GameObject GetCurrentPlayer()
    {
        return players[currentPlayerIndex];
    }

    public GameObject[] GetAllPlayers()
    {
        return players;
    }
}

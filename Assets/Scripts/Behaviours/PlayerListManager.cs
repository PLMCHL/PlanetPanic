using UnityEngine;

public class PlayerListManager : MonoBehaviour
{
    public GameObject PlayerPrefab;

    private static PlayerListManager instance;

    private int currentPlayerIndex;
    private GameObject[] players;

    public static PlayerListManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerListManager>();
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

using UnityEngine;

public class PlayerListManager : MonoBehaviour
{
    public GameObject PlayerPrefab;

    private static PlayerListManager instance;

    private GameObject[] players;

    private int _currentPlayerIndex;
    public int CurrentPlayerIndex {
        get {
            return _currentPlayerIndex;
        } 
        
        set {
            _currentPlayerIndex = value;

            RefreshPlayerZIndex();
        } 
    }

    public void RefreshPlayerZIndex()
    {
        if (players == null)
        {
            return;
        }

        // Pull current player sprite to front
        for (int i = 0; i < players.Length; i++)
        {
            var spriteRenderer = players[i].GetComponent<SpriteRenderer>();

            if (i != CurrentPlayerIndex)
            {
                spriteRenderer.sortingOrder = 10;
            }
            else
            {
                spriteRenderer.sortingOrder = 11;
            }
        }
    }

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

    public void EndPlayerTurn()
    {
        CurrentPlayerIndex = (CurrentPlayerIndex + 1) % players.Length;
    }

    public GameObject GetCurrentPlayer()
    {
        if (players == null)
        {
            return null;
        }

        return players[CurrentPlayerIndex];
    }

    public GameObject[] GetAllPlayers()
    {
        return players;
    }
}

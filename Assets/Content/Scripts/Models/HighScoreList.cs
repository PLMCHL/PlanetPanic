using System.Collections.Generic;
using UnityEngine;

public class HighScoreList
{
    public int Value { get; private set; }
    private List<GameObject> PlayerList;

    public HighScoreList(int value, GameObject player)
    {
        this.Value = value;

        PlayerList = new List<GameObject>();
        PlayerList.Add(player);
    }

    public void AddPlayerToList(GameObject player)
    {
        PlayerList.Add(player);
    }

    public List<GameObject> GetPlayerList()
    {
        return new List<GameObject>(PlayerList);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    private const int DICE_FACES = 8;

    private int currentRoll = 0;
    private bool rolling = false;

    private static DiceRoller instance;
    public static DiceRoller Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DiceRoller>();
            }
            return instance;
        }
    }

    void Update()
    {
        if (rolling)
        {
            SetValue(Random.Range(1, DICE_FACES));
        }
    }

    public void StartRoll()
    {
        rolling = true;
    }

    public int GetValue()
    {
        rolling = false;
        return currentRoll;
    }

    public void SetValue(int value)
    {
        currentRoll = value;

        var currentRollObj = gameObject.transform.Find("DiceRollerText").GetComponent<Text>();
        currentRollObj.text = this.currentRoll.ToString();
    }

    public void Clear()
    {
        rolling = false;

        var currentRollObj = gameObject.transform.Find("DiceRollerText").GetComponent<Text>();
        currentRollObj.text = "R";
    }
}

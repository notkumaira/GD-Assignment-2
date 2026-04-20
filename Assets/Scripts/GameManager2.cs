using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance;
    public LevelTwoLogic levelTwoLogic;


    public SLots[] slots;

    void Awake()
    {
        instance = this;
    }

    public void CheckWin()
    {
        foreach (SLots slot in slots)
        {
            if (!slot.isFilled)
            {
                return; // not all filled yet
            }
        }

        WinGame();
    }

    void WinGame()
    {
        Debug.Log("YOU WIN!");        // show win UI here
        levelTwoLogic.DisplayWinPanel();

    }
}
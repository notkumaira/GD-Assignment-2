using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    public static GameManager3 instance;
    public LevelThreeLogic levelThreeLogic;


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
        levelThreeLogic.DisplayWinPanel();

    }
}
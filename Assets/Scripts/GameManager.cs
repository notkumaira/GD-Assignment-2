using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public LevelOneLogic levelOneLogic;
   

    public SLots[] slots;

    public bool isLevelOneComplete = false;

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
        levelOneLogic.DisplayWinPanel();
        isLevelOneComplete = true;

    }
}
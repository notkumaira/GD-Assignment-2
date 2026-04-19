using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PauseFunction pauseFunction;

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
        pauseFunction.DisplayWinPanel();
    }
}
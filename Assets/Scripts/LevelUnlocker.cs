using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelOne.interactable = true;
        levelTwo.interactable = false;
        levelThree.interactable = false;

        if (PlayerPrefs.GetInt("LevelTwoUnlocked", 0) == 1)
        {
            levelTwo.interactable = true;
        }

        if (PlayerPrefs.GetInt("LevelThreeUnlocked", 0) == 1)
        {
            levelThree.interactable = true;
        }
    }
}

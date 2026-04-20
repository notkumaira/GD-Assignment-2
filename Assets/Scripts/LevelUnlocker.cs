using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;
    public GameObject DialogueLevel1;
    public GameObject DialogueLevel2;
    public GameObject DialogueLevel3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reset everything first
        levelOne.interactable = false;
        levelTwo.interactable = false;
        levelThree.interactable = false;

        DialogueLevel1.SetActive(false);
        DialogueLevel2.SetActive(false);
        DialogueLevel3.SetActive(false);

        // Check highest progress FIRST
        if (PlayerPrefs.GetInt("LevelThreeUnlocked", 0) == 1)
        {
            levelThree.interactable = true;
            DialogueLevel3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("LevelTwoUnlocked", 0) == 1)
        {
            levelTwo.interactable = true;
            DialogueLevel2.SetActive(true);
        }
        else
        {
            levelOne.interactable = true;
            DialogueLevel1.SetActive(true);
        }
    }
}

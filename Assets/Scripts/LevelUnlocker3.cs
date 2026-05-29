using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker3 : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;
    public GameObject DialogueLevel3;
    public Button DialogueContinue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reset everything first
        levelOne.interactable = false;
        levelTwo.interactable = false;
        levelThree.interactable = false;

        DialogueContinue.onClick.AddListener(LVL3Continue);
        
        DialogueLevel3.SetActive(true);

    
    }
    private void LVL3Continue()
        {
         if (PlayerPrefs.GetInt("LevelThreeUnlocked", 0) == 1)
        {
            levelOne.interactable = true;
            levelTwo.interactable = true;
            levelThree.interactable = true;
            DialogueLevel3.SetActive(false);
        }   
        else 
        {
            levelOne.interactable = true;
            levelTwo.interactable = true;
            levelThree.interactable = false;    
            DialogueLevel3.SetActive(false);
            Time.timeScale = 1f;
        }
        }
}


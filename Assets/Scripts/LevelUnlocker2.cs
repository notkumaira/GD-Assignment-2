using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker2 : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;
    public GameObject DialogueLevel2;
    public Button DialogueContinue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reset everything first
        levelOne.interactable = false;
        levelTwo.interactable = false;
        levelThree.interactable = false;
        DialogueContinue.onClick.AddListener(LVL2Continue);
        
        DialogueLevel2.SetActive(true);

    
    }
    private void LVL2Continue()
        {
         if (PlayerPrefs.GetInt("LevelTwoUnlocked", 0) == 1)
        {
            levelOne.interactable = true;
            levelTwo.interactable = true;
            levelThree.interactable = false;
            DialogueLevel2.SetActive(false);
            Debug.Log("remove panel");
        }   
        else 
        {
            levelOne.interactable = true;
            levelTwo.interactable = false;
            levelThree.interactable = false;    
            DialogueLevel2.SetActive(false);
            Time.timeScale = 1f;
            Debug.Log("remove panel");
        }
        }

}


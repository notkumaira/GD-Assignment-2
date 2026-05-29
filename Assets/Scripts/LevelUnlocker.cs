using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public Button levelOne;
    public Button levelTwo;
    public Button levelThree;
    public GameObject DialogueLevel1;
    public Button DialogueContinue;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reset everything first
        levelOne.interactable = false;
        levelTwo.interactable = false;
        levelThree.interactable = false;

        DialogueLevel1.SetActive(true);
        DialogueContinue.onClick.AddListener(LVL1Continue);   
    }
    private void LVL1Continue()
        {
            levelOne.interactable = true;
            levelTwo.interactable = false;
            levelThree.interactable = false;    
            DialogueLevel1.SetActive(false);
            Time.timeScale = 1f;
        }
}

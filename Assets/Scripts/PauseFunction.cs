using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseFunction : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public GameObject PausePanel;
    public Button QuitButton;
    public Button TitlePageButton;
    void Start()
    {
        PausePanel.SetActive(false);
        ResumeButton.onClick.AddListener(HidePausePanel);
        PauseButton.onClick.AddListener(DisplayPausePanel);
        QuitButton.onClick.AddListener(QuitGame);
        TitlePageButton.onClick.AddListener(LoadStartScene);
    }

    private void HidePausePanel()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void DisplayPausePanel()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;    
    }

    private void QuitGame()
    {
        Time.timeScale = 1f; 
        Debug.Log("Game Quit");
        Application.Quit();
    }

    private void LoadStartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScene");
    }
}

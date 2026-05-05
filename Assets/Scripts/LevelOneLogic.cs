
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOneLogic : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public GameObject PausePanel;
    public Button QuitButton;
    public Button TitlePageButton;
    public GameObject WinPanel;
    public Button ContinueButton;
    void Start()
    {
        PausePanel.SetActive(false);
        WinPanel.SetActive(false);
        ResumeButton.onClick.AddListener(HidePausePanel);
        PauseButton.onClick.AddListener(DisplayPausePanel);
        QuitButton.onClick.AddListener(QuitGame);
        TitlePageButton.onClick.AddListener(LoadTitleScene);
        ContinueButton.onClick.AddListener(HideWinPanel);
        ContinueButton.onClick.AddListener(LoadStartScene);
        PlayerPrefs.SetInt("LevelTwoUnlocked", 0);
        PlayerPrefs.SetInt("LevelThreeUnlocked", 0);
        PlayerPrefs.Save();
    }

    private void HideWinPanel()
    {
        WinPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void DisplayWinPanel()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
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
        PlayerPrefs.SetInt("LevelTwoUnlocked", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("StartScene");
    }

    private void LoadTitleScene()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("OpenScene");
    }
}

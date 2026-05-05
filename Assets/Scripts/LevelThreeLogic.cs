
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelThreeLogic : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public GameObject PausePanel;
    public Button QuitButton;
    public Button TitlePageButton;
    public GameObject WinPanel;
    public Button EndButton;
    public Button RetryButton;
    void Start()
    {
        PausePanel.SetActive(false);
        WinPanel.SetActive(false);
        ResumeButton.onClick.AddListener(HidePausePanel);
        PauseButton.onClick.AddListener(DisplayPausePanel);
        QuitButton.onClick.AddListener(QuitGame);
        TitlePageButton.onClick.AddListener(LoadStartScene);
        EndButton.onClick.AddListener(QuitGame);
        RetryButton.onClick.AddListener(RetryLevel);
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
        SceneManager.LoadScene("OpenScene");
    }

    private void RetryLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelThree");
    }
}

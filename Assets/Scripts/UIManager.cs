using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button StartButton;
    public GameObject StartPanel;

    public Button PauseButton;
    public Button ResumeButton;
    public GameObject PausePanel;
    void Start()
    {
        StartButton.onClick.AddListener(HidePanel);
        PausePanel.SetActive(false);
        ResumeButton.onClick.AddListener(HidePausePanel);
        PauseButton.onClick.AddListener(DisplayPausePanel);
    }

    private void HidePanel()
    {
        StartPanel.SetActive(false);
    }

    private void HidePausePanel()
    {
        PausePanel.SetActive(false);
    }

    private void DisplayPausePanel()
    {
        PausePanel.SetActive(true);
    }
}

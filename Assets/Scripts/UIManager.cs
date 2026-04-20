using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Button StartButton;
    public GameObject StartPanel;
    void Start()
    {
        StartButton.onClick.AddListener(HidePanel);
    }

    private void HidePanel()
    {
        SceneManager.LoadScene("StartScene");
    }
}

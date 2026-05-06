using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChooser : MonoBehaviour
{
    public void LoadLevelOne()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelOne");
    }

    public void LoadLevelTwo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelTwo");
    }

    public void LoadLevelThree()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelThree");
    }
   
    
}

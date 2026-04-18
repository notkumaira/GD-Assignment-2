using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float maxTime = 10f;        
    private float currentTime;

    public Image timerBar;
    public GameObject failPanel;

    void Start()
    {
        currentTime = maxTime;
        failPanel.SetActive(false);
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            float fillAmount = currentTime / maxTime;
            timerBar.fillAmount = fillAmount;
        }
        else
        {
            currentTime = 0;
            timerBar.fillAmount = 0;

            TimeUp();
        }
    }

    void TimeUp()
    {
        Debug.Log("Time's up!");
        failPanel.SetActive(true);
    }
}

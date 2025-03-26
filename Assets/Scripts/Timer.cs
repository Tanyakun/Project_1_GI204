using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;

    public TextMeshProUGUI countdownText;

    bool isGameOver = false;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (isGameOver) return;

        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            FindFirstObjectByType<GameManager>().EndGame();
            isGameOver = true;
        }
    }
}

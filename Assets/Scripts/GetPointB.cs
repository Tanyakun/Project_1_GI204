using TMPro;
using UnityEngine;

public class GetPointB : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public int maxScore = 300;

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PCH"))
        {
            score += 1;
        }
        else if (other.CompareTag("VRT"))
        {
            score += 2;
        }
        else if (other.CompareTag("TCT"))
        {
            score += 3;
        }
        else if (other.CompareTag("BCS"))
        {
            score += 4;
        }
        else if (other.CompareTag("SPN"))
        {
            score += 5;
        }
        else if (other.CompareTag("TRX"))
        {
            score += 6;
        }

        UpdateScoreText();
        Destroy(other.gameObject);

        CheckWinCondition(); // ตรวจสอบว่าชนะหรือไม่
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    private void CheckWinCondition()
    {
        if (score >= maxScore)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}

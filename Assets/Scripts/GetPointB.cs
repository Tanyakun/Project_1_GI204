using TMPro;
using UnityEngine;

public class GetPointB : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // UI Text สำหรับแสดงคะแนน
    private int score = 0; // คะแนนเริ่มต้น

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
        Destroy(other.gameObject); // ทำลาย Object ที่ชนกับ Trigger
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}

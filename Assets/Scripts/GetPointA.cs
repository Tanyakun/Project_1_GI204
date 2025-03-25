using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetPointA : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // UI Text สำหรับแสดงคะแนน
    private int score = 0; // คะแนนเริ่มต้น

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pachycephalosaurus"))
        {
            score += 1;
        }
        else if (other.CompareTag("Velociraptor"))
        {
            score += 2;
        }
        else if (other.CompareTag("Triceratops"))
        {
            score += 3;
        }
        else if (other.CompareTag("Brachiosaurus"))
        {
            score += 4;
        }
        else if (other.CompareTag("Spinosurus"))
        {
            score += 5;
        }
        else if (other.CompareTag("T-rex"))
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

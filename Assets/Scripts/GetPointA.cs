using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetPointA : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // UI Text สำหรับแสดงคะแนน
    public int score = 0; // คะแนนเริ่มต้น
    public int maxScore = 300; //คะแนนสูงสุด

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
        Destroy(other.gameObject); // ลบ Object เมื่อชน

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
            FindFirstObjectByType<GameManager>().EndGame(); // บอก GameManager ให้เช็กผลลัพธ์
        }
    }
}

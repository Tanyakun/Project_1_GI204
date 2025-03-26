using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiWin;
    public GameObject uiLoss;
    public GameObject uiTie;

    private GetPointA playerA;
    private GetPointB playerB;

    void Start()
    {
        uiWin.SetActive(false);
        uiLoss.SetActive(false);
        uiTie.SetActive(false);

        playerA = FindFirstObjectByType<GetPointA>();
        playerB = FindFirstObjectByType<GetPointB>();
    }

    public void EndGame()
    {
        int scoreA = playerA.score;
        int scoreB = playerB.score;

        if (scoreA >= 300 && scoreB >= 300)
        {
            uiTie.SetActive(true);
        }
        else if (scoreA >= 300)
        {
            uiWin.SetActive(true);
        }
        else if (scoreB >= 300)
        {
            uiLoss.SetActive(true);
        }
        else if (scoreA > scoreB)
        {
            uiWin.SetActive(true);
        }
        else if (scoreA < scoreB)
        {
            uiLoss.SetActive(true);
        }
        else
        {
            uiTie.SetActive(true);
        }

        Time.timeScale = 0; // หยุดเกม
    }
}
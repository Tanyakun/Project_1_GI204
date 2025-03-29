using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public RectTransform creditsText; // UI Text หรือ Panel ที่ต้องการให้ลอยขึ้น
    public float speed = 100f; // ความเร็วในการเลื่อนขึ้น
    public float resetPositionY = -500f; // ตำแหน่งเริ่มต้น (ข้างล่างสุด)
    public float endPositionY = 800f; // ตำแหน่งสูงสุดก่อนรีเซ็ต

    void Start()
    {
        Time.timeScale = 1f; // ทำให้เกมทำงานปกติ
    }

    void Update()
    {
        
        // เลื่อนตำแหน่ง UI ขึ้นไปเรื่อยๆ
        creditsText.anchoredPosition += Vector2.up * speed * Time.deltaTime;

        // ถ้าถึงจุดสูงสุด ให้รีเซ็ตกลับไปตำแหน่งเริ่มต้น
        if (creditsText.anchoredPosition.y >= endPositionY)
        {
            creditsText.anchoredPosition = new Vector2(creditsText.anchoredPosition.x, resetPositionY);
        }
    }

}

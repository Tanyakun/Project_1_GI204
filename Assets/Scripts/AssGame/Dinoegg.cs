using UnityEngine;

public class Dinoegg : MonoBehaviour
{
    public float floatSpeed = 2f;  // ความเร็วในการลอยขึ้นลง
    public float floatHeight = 0.5f;  // ระยะที่ลอยขึ้นลง

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;  // ตำแหน่งเริ่มต้นของวัตถุ
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}

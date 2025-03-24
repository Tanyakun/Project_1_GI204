using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] lanes; // จุดเลนที่กำหนด
    private int currentLane = 0;  // เลนปัจจุบัน
    public float changeLaneInterval = 2.0f; // เปลี่ยนเลนทุกๆ กี่วินาที
    public float spawnDinoInterval = 3.0f; // Spawn ไดโนเสาร์ทุกๆ กี่วินาที
    public float speed = 2f;
    private Vector3 moveDirection = Vector3.zero;

    public GameObject[] enemyDinoPrefabs; // ไดโนเสาร์ที่ศัตรูปล่อยได้
    public Transform spawnPoint; // จุด Spawn ไดโนเสาร์ (เป็นลูกของ Enemy)

    void Start()
    {
        // ตั้งค่าตำแหน่งเริ่มต้นเป็น Lane แรก
        if (lanes.Length > 0)
        {
            transform.position = lanes[currentLane].position;
        }

        // เริ่มให้เปลี่ยนเลนแบบสุ่มทุกๆ X วินาที
        InvokeRepeating(nameof(RandomMoveLane), changeLaneInterval, changeLaneInterval);

        // ให้ Enemy ปล่อยไดโนเสาร์ทุกๆ Y วินาที
        InvokeRepeating(nameof(SpawnDino), spawnDinoInterval, spawnDinoInterval);
    }

    void RandomMoveLane()
    {
        if (lanes.Length <= 1) return; // ถ้ามีแค่เลนเดียวไม่ต้องเปลี่ยน

        int newLane;
        do
        {
            newLane = Random.Range(0, lanes.Length); // สุ่มเลนใหม่
        } while (newLane == currentLane); // ห้ามสุ่มตำแหน่งเดิมซ้ำ

        currentLane = newLane;
        transform.position = new Vector3(transform.position.x, lanes[currentLane].position.y, lanes[currentLane].position.z);
    }

    void SpawnDino()
    {
        if (spawnPoint != null && enemyDinoPrefabs.Length > 0)
        {
            int dinoIndex = Random.Range(0, enemyDinoPrefabs.Length);
            Quaternion spawnRotation = Quaternion.Euler(0, -180, 0);

            GameObject dino = Instantiate(enemyDinoPrefabs[dinoIndex], spawnPoint.position, spawnRotation);
        }
    }

    public void SetDirection(Vector3 direction)
    {
        moveDirection = direction.normalized; // กำหนดทิศทาง
    }
}

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;  // ไดโนเสาร์ที่ปล่อยได้
    public Transform spawnPoint;      // จุด Spawn (เป็นลูกของ Player)

    void Update()
    {
        // ปล่อยไดโนเสาร์เมื่อกดปุ่ม Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDino();
        }
    }

    void SpawnDino()
    {
        if (spawnPoint != null && dinoPrefabs.Length > 0)
        {
            int dinoIndex = 0; // ตอนนี้เลือกไดโนเสาร์ตัวแรกก่อน
            GameObject dino = Instantiate(dinoPrefabs[dinoIndex], spawnPoint.position, Quaternion.identity);
        }
    }
}


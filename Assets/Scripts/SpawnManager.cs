using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;  // ไดโนเสาร์ที่ปล่อยได้
    public Transform spawnPoint;      // จุด Spawn (เป็นลูกของ Player)
    public float spawnCooldown = 1f;  // คูลดาวน์ 1 วินาที

    private bool canSpawn = true;  // ตัวแปรเช็คว่าปล่อยได้หรือไม่

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            StartCoroutine(SpawnDino());
        }
    }

    IEnumerator SpawnDino()
    {
        canSpawn = false; // ปิดการปล่อยชั่วคราว

        if (spawnPoint != null && dinoPrefabs.Length > 0)
        {
            int dinoIndex = Random.Range(0, dinoPrefabs.Length);
            Instantiate(dinoPrefabs[dinoIndex], spawnPoint.position, Quaternion.identity);
        }

        yield return new WaitForSeconds(spawnCooldown); // รอ 1 วินาที
        canSpawn = true; // กลับมาให้ปล่อยได้อีกครั้ง
    }

    /*public GameObject[] dinoPrefabs;  // ไดโนเสาร์ที่ปล่อยได้
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
            // เลือกไดโนเสาร์แบบสุ่ม
            int dinoIndex = Random.Range(0, dinoPrefabs.Length);

            GameObject dino = Instantiate(dinoPrefabs[dinoIndex], spawnPoint.position, Quaternion.identity);
        }
    }*/
}


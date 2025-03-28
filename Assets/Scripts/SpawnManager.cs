using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;  // ไดโนเสาร์ที่ปล่อยได้
    public Transform spawnPoint;      // จุด Spawn (เป็นลูกของ Player)
    public float spawnCooldown = 1f;  // คูลดาวน์ 1 วินาที

    public Sprite[] dinoSprites;      // รูปไดโนเสาร์ที่ใช้ใน UI
    public Image dinoPreview;         // รูป UI ที่เปลี่ยนตามไดโนเสาร์
    private int currentDinoIndex;  // ไดโนเสาร์ที่กำลังจะแสดงผล
    private int nextDinoIndex;  // ไดโนเสาร์ตัวถัดไปที่สุ่มไว้

    private bool canSpawn = true;  // ตัวแปรเช็คว่าปล่อยได้หรือไม่

    void Start()
    {
        nextDinoIndex = Random.Range(0, dinoPrefabs.Length); // สุ่มไดโนตัวแรก
        UpdateDinoPreview(); // อัปเดต UI
    }

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

        currentDinoIndex = nextDinoIndex;

        nextDinoIndex = Random.Range(0, dinoPrefabs.Length);
        UpdateDinoPreview(); // อัปเดต UI ทันที


        if (spawnPoint != null && dinoPrefabs.Length > 0)
        {
            Instantiate(dinoPrefabs[currentDinoIndex], spawnPoint.position, Quaternion.identity);
        }

        yield return new WaitForSeconds(spawnCooldown); // รอ 1 วินาที
        canSpawn = true; // กลับมาให้ปล่อยได้อีกครั้ง

    }

    void UpdateDinoPreview()
    {
        if (dinoPreview != null && dinoSprites.Length > nextDinoIndex)
        {
            dinoPreview.sprite = dinoSprites[nextDinoIndex];
        }
    }
}


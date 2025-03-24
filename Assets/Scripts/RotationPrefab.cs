using UnityEngine;

public class RotationPrefab : MonoBehaviour
{
    public GameObject prefab; // Prefab ที่จะ Spawn
    public Transform spawnPoint; // ตำแหน่ง Spawn

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        if (prefab != null && spawnPoint != null)
        {
            // หมุนไปทาง -X (แกน Y หมุน 90 องศา)
            Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

            // Spawn Prefab
            GameObject spawnedObject = Instantiate(prefab, spawnPoint.position, spawnRotation);
        }
    }
}

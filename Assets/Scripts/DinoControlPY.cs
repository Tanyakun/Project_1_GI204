using UnityEngine;

public class DinoControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;  // ความเร็ว (กำหนดจาก Inspector)
    [SerializeField] private float mass = 1f;   // มวล (กำหนดจาก Inspector)

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;  // ตั้งค่ามวล
        rb.linearVelocity = transform.forward * speed;  // ให้ Object เคลื่อนที่ไปข้างหน้า
    }
}

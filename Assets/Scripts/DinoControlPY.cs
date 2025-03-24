using UnityEngine;

public class DinoControlPY : MonoBehaviour
{
    [SerializeField] private float speed = 5f;  // ความเร็ว (กำหนดจาก Inspector)
    [SerializeField] private float mass = 1f;   // มวล (กำหนดจาก Inspector)

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;  // ตั้งค่ามวล
    }

    void FixedUpdate()
    {
        rb.linearVelocity = transform.right * speed;  // ทำให้เคลื่อนที่ไปข้างหน้าเรื่อยๆ
    }
}

using UnityEngine;

public class TerrainEffect : MonoBehaviour
{
    public float mudDrag = 5f;
    public float sandDrag = 3f;
    private float defaultDrag = 1f; // ค่า Default Drag ของพื้น Dirt

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb == null) return; // ออกจากฟังก์ชันหากไม่มี Rigidbody

        int layer = other.gameObject.layer; // อ่านค่า Layer ของไดโนเสาร์

        // เช็คว่า Object เป็นทีม A หรือทีม B
        if (layer == LayerMask.NameToLayer("DinoTeamA") || layer == LayerMask.NameToLayer("DinoTeamB"))
        {
            // อ่านค่า Default Drag เมื่อเข้าสู่พื้นครั้งแรก
            if (rb.linearDamping == 0)
                rb.linearDamping = defaultDrag;

            // กำหนดค่า Drag ตามประเภทพื้น
            if (gameObject.CompareTag("Mud"))
                rb.linearDamping = mudDrag;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb == null) return;

        int layer = other.gameObject.layer;

        if (layer == LayerMask.NameToLayer("DinoTeamA") || layer == LayerMask.NameToLayer("DinoTeamB"))
        {
            rb.linearDamping = defaultDrag; // กลับไปใช้ค่า Drag เริ่มต้นเมื่อออกจากพื้น
        }
    }
}

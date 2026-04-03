using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;
    public float speedIncrease = 1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        speed += speedIncrease * Time.deltaTime;
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + transform.forward * moveInput * speed * Time.deltaTime);

        float turnInput = Input.GetAxis("Horizontal");
        Quaternion turnRotation = Quaternion.Euler(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
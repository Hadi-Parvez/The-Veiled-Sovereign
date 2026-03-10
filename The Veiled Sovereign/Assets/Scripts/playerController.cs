using UnityEngine;
using UnityEngine.Rendering;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;

    // Health System
    public int maxHealth = 3;
    private int currentHealth;

    private void Start()
    {

        currentHealth = maxHealth;
        Debug.Log("Player HP: " + currentHealth);

    }
    public void Update()
    {

    }


    private void FixedUpdate()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection.x = moveX;
        moveDirection.y = moveY;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = aimAngle;
    }
}

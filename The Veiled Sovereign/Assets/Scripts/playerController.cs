using UnityEngine;
using UnityEngine.Rendering;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float runSpeed = 10f;
    private float currentSpeed;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;

    // Health System
    public int maxHealth = 3;
    private int currentHealth;

    public GameObject arrowPrefab;
    public float arrowForce = 5f;

    public enum MovementMode
    {
        TopDown,
        SideScroller
    }

    public MovementMode movementMode = MovementMode.TopDown;

    private void Start()
    {

        currentHealth = maxHealth;
        Debug.Log("Player HP: " + currentHealth);

    }
    public void Update()
    {

        //Run section

        if (Input.GetKey(KeyCode.LeftShift)){

            currentSpeed = runSpeed;

        }
        else{

            currentSpeed = moveSpeed;

        }
        // Left mouse button pressed
        if (Input.GetMouseButtonDown(0))
        {
            // If right mouse button is being held, shoot arrow
            if (Input.GetMouseButton(1))
            {
                ShootBow();
            }

            // Else using sword
            else
            {
                SwordAttack();
            }
        }
    }




    private void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (movementMode == MovementMode.TopDown)
        {
            moveDirection.x = moveX;
            moveDirection.y = moveY;

            rb.linearVelocity = new Vector2(moveDirection.x * currentSpeed, moveDirection.y * currentSpeed);

            Vector2 aimDirection = mousePosition - rb.position;
            float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 90f;
            rb.rotation = aimAngle;
        }

        else if (movementMode == MovementMode.SideScroller)
        {
            rb.linearVelocity = new Vector2(moveX * currentSpeed, rb.linearVelocity.y);

            if (moveX > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else if (moveX < 0)
                transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Uses the sword to attack

    void SwordAttack()
    {
        Debug.Log("Sword Attack!");

        // Add sword animation or damage logic here
    }

    //Shoots arrow

    void ShootBow()
    {
        Debug.Log("Shoot Arrow!");



    }
}

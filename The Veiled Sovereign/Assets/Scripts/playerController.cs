using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum MovementMode
    {
        TopDown,
        SideScroller
    }

    [Header("Movement")]
    public float moveSpeed = 5f;
    public float runSpeed = 10f;

    [Header("Components")]
    public Rigidbody2D rb;
    public Animator animator;

    [Header("Movement Mode")]
    public MovementMode movementMode = MovementMode.TopDown;

    private Vector2 movement;
    private Vector2 lastDirection = Vector2.down;

    private void Update()
    {
        // Get movement input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Prevent diagonal movement from being faster
        movement = movement.normalized;

        // Remember the last direction
        if (movement != Vector2.zero)
        {
            lastDirection = movement;
        }

        // Check if player is running
        bool isRunning =
            Input.GetKey(KeyCode.LeftShift) &&
            movement != Vector2.zero;

        // Send direction to Animator
        animator.SetFloat("Horizontal", lastDirection.x);
        animator.SetFloat("Vertical", lastDirection.y);

        // Send movement speed to Animator
        animator.SetFloat("Speed", movement.magnitude);

        // Send running state to Animator
        animator.SetBool("IsRunning", isRunning);

        // Sword attack - Left Mouse Button
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("IsAttacking", true);
        }
    }

    private void FixedUpdate()
    {
        // Determine movement speed
        float currentSpeed = Input.GetKey(KeyCode.LeftShift)
            ? runSpeed
            : moveSpeed;

        // Top-down movement
        if (movementMode == MovementMode.TopDown)
        {
            rb.linearVelocity = movement * currentSpeed;
        }

        // Side-scroller movement
        else if (movementMode == MovementMode.SideScroller)
        {
            rb.linearVelocity = new Vector2(
                movement.x * currentSpeed,
                rb.linearVelocity.y
            );

            // Flip character
            if (movement.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (movement.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    // Called by the sword attack animation
    public void EndAttack()
    {
        animator.SetBool("IsAttacking", false);
    }
}
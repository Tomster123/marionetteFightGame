using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize so diagonal movement isn't faster
        movement = movement.normalized;

        // Flip sprite left/right
        if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isMoving = true;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isMoving)
        {
            // WASD / Arrow Keys Input
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            // Prevent faster diagonal movement
            input = input.normalized;

            // Flip sprite left/right
            if (input.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (input.x < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            input = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;
    }
}
//flashlight code 

public class PlayerFlashlight : MonoBehaviour
{
    [Header("Flashlight Settings")]
    public Light flashlight;
    public KeyCode toggleKey = KeyCode.F;

    [Header("Status")]
    public bool hasFlashlight = false;

    private bool flashlightOn = false;

    void Start()
    {
        if (flashlight != null)
        {
            flashlight.enabled = false;
        }
    }

    void Update()
    {
        if (!hasFlashlight)
            return;

        if (Input.GetKeyDown(toggleKey))
        {
            flashlightOn = !flashlightOn;
            flashlight.enabled = flashlightOn;
        }
    }

    public void PickUpFlashlight()
    {
        hasFlashlight = true;

        Debug.Log("You found a flashlight! Press F to use it.");
    }
}
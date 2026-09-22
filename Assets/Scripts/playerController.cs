using UnityEngine;
using UnityEngine.InputSystem;
public class playerController : MonoBehaviour
{

    public float moveSpeed;
    public bool isMoving;
    private Vector2 input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");


        }
    }
}

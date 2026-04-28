using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb2d;
    private Vector2 moveInput;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    public void OnMove(InputValue value)
    {

        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
 
        rb2d.linearVelocity = moveInput * speed;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb2d;
    private Vector2 moveInput;
    private Animator animator;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

   
    public void OnMove(InputValue value)
    {
        animator.SetBool("isWalking", true);
    
        moveInput = value.Get<Vector2>();

        //if ( Oyuncu hareket etmeyi bıraktığında )
        //{
        //    animator.SetBool("isWalking", false);
        //    animator.SetFloat("LastInputX", moveInput.x);
        //    animator.SetFloat("LastInputY", moveInput.y);
        //}

        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);
        
        // Bir de oyuncu sola doğru hareket ettiği zaman karakterin ters tarafa dönmesi lazım
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = moveInput * speed;
    }
}
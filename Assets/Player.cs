using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 moveInput;
    [SerializeField] Rigidbody2D rb;
    float speed = 5f;
    //bool playerHasHorizontalVelocityToRight;

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * speed, moveInput.y * speed);
        rb.velocity = playerVelocity;

        bool playerHasHorizontalVelocityToRight = Mathf.Abs(rb.velocity.x) > 0;
        if(playerHasHorizontalVelocityToRight)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x), 1f);
        }
        
    }
}

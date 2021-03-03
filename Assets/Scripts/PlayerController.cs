using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    float movement = 0f;
    public static bool isGrounded;

    public float speed = 5f;
    public float jumpVelocity = 7f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            rb2d.velocity = Vector2.up * jumpVelocity;
        }

        
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movement * speed, rb2d.velocity.y);
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheck == null) 
        {
            return;
        }

        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}

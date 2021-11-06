using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// I still gotta figure out how to make the jumping action funciton properly. I also do not want the sphere to role around. I've got to set boundries as well.
    /// I need also enable collisions with the platform, I don't like the idea of phasing through them. 
    /// </summary>
    public float moveSpeed;
    public float jumpForce;
    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    public float checkRadius;

    private Rigidbody rb;
    private bool facingRight = true;
    private float moveDireciton;
    private bool isJumping = false;
    private bool isGrounded = true;
    

    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(groundCheck.position, checkRadius, groundObjects);

        moveDireciton = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }

        // turn character 180 degrees
        if(moveDireciton> 0 && !facingRight)
        {
            flipCharacter();
        }
        else if (moveDireciton < 0 && facingRight)
        {
            flipCharacter();
        }

        //move
        rb.velocity = new Vector3(moveDireciton * moveSpeed, rb.velocity.y);
        if (isJumping)
        {
            rb.AddForce(new Vector3(0f, jumpForce));
            isGrounded = false;
        }
    }

    private void flipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}

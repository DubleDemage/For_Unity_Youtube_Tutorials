using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;

    [SerializeField]
    [Range(0, 1)] float LerpConstant;

    Rigidbody rb;

    public float jumpSpeed;
    bool midJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Jump();
    }

    void Movement()
    {
     
         float h = Input.GetAxis("Horizontal");
         Vector2 movement = new Vector2(h * playerSpeed, rb.velocity.y);
         rb.velocity = Vector2.Lerp(rb.velocity, movement, LerpConstant);
        
    }

    void Jump()
    {
        if(Input.GetButton("Jump") && (midJump == false))
        {
            rb.velocity = new Vector3(0, jumpSpeed, 0);
            midJump = true;
        }
        if(rb.velocity.y == 0)
        {
            midJump = false;
        }
    }
}

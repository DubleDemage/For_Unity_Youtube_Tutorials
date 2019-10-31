using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour
{
    public float playerSpeed;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void RightMove()
    {
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
    }

    public void LeftMove()
    {
        rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
    }

    public void UpMove()
    {
        rb.velocity = new Vector2(rb.velocity.x, playerSpeed);
    }

    public void DownMove()
    {
        rb.velocity = new Vector2(rb.velocity.x, -playerSpeed);
    }

    public void StopMove()
    {
        rb.velocity = new Vector2(0, 0);
    }


}

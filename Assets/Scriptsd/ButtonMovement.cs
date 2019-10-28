using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour
{
    public float playerSpeed;

    Rigidbody rb;

   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    public void MoveRight()
    {
        transform.position += Vector3.right * 15.0f * Time.deltaTime;
    }

    public void MoveLeft()
    {

        transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
    }
}

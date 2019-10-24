using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementUsingTouch : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        TouchMovement();
    }

    void TouchMovement()
    {
        Vector2 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));
        if(Input.touchCount > 0)
        {
            transform.position = new Vector3(touch.x, transform.position.y, transform.position.z);
        }
    }
}

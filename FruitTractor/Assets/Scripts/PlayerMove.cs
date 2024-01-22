using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speedX = 1f;
    private float speedY = -0.5f;
    private bool ChangeDirection = true;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(speedX, speedY, 0) * Time.deltaTime;
    }

    public void ChangeMoveRigthe()
    {
        if (ChangeDirection)
        {
            speedX *= -1;
            ChangeDirection = false;
        }
        else
        {
            speedY *= -1;
            ChangeDirection = true;
        }
    }

    public void ChangeMoveLeft()
    {
        if (ChangeDirection)
        {
            speedY *= -1;
            ChangeDirection = false;
        }
        else
        {
            speedX *= -1;
            ChangeDirection = true;
        }
    }

}

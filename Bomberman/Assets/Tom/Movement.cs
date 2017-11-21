using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public string inputX;
    public string inputZ;
    public bool player1;

    public void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement ()
    {
        
        float x = Input.GetAxisRaw(inputX);
        float z = Input.GetAxisRaw(inputZ);

        Vector3 dir;

        if (x != 0)
        {
            if (player1)
            {
                if (Input.GetButtonDown("Horizontal"))
                {
                    dir = (x < 0) ? Vector3.left : Vector3.right;
                    transform.eulerAngles = (x < 0) ? Vector3.up * 270 : Vector3.up * 90;
                    if (!Physics.Raycast(transform.position, dir, 1))
                        transform.position += dir;
                }
            }
            else
            {
              if (Input.GetButtonDown("Horizon"))
              {
                dir = (x < 0) ? Vector3.left : Vector3.right;
                transform.eulerAngles = (x < 0) ? Vector3.up * 270 : Vector3.up * 90;
                if (!Physics.Raycast(transform.position, dir, 1))
                    transform.position += dir;
                }
            }
                

        }
        else if (z != 0)
        {
            if (player1)
            {
                if (Input.GetButtonDown("Vertical"))
                {
                    dir = (z < 0) ? Vector3.back : Vector3.forward;
                    transform.eulerAngles = (z < 0) ? Vector3.up * 180 : Vector3.up * 0;
                    if (!Physics.Raycast(transform.position, dir, 1))
                        transform.position += dir;
                }
            }
            else
                {
                    if (Input.GetButtonDown("Verti"))
                    {
                        dir = (z < 0) ? Vector3.back : Vector3.forward;
                        transform.eulerAngles = (z < 0) ? Vector3.up * 180 : Vector3.up * 0;
                        if (!Physics.Raycast(transform.position, dir, 1))
                            transform.position += dir;
                    }
                }
        }
    }
}

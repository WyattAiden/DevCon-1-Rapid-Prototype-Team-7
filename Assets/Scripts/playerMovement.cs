using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody rb;
    //Player move speed
    public float moveSpeed = 10;

    //Player jump height
    public float jumpHeight = 5;

    private bool perspectiveSwap;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        perspectiveSwap = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R) && perspectiveSwap)
        {
            perspectiveSwap = false;
        }

        if (Input.GetKeyDown(KeyCode.R) && !perspectiveSwap)
        {
            perspectiveSwap = true;
        }


        if (!perspectiveSwap)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.MovePosition(transform.position + Vector3.left * moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.MovePosition(transform.position + Vector3.right * moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                rb.MovePosition(transform.position + Vector3.forward * moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.MovePosition(transform.position + Vector3.back * moveSpeed * Time.deltaTime);
            }
        }

        if (perspectiveSwap)
        {

        }
    }
}

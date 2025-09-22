using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody rb;
    //Player move speed
    public float moveSpeed = 10;

    //Player jump height
    public float jumpHeight = 8f;

    public bool perspectiveSwap;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        perspectiveSwap = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (perspectiveSwap)
            {
                perspectiveSwap = false;
                anim.SetBool("perspectiveSwap", perspectiveSwap);
            }
            
            else
            {
                perspectiveSwap = true;
                anim.SetBool("perspectiveSwap", perspectiveSwap);
            }
            
        }


        if (perspectiveSwap && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

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
            if (Input.GetKey(KeyCode.A))
            {
                rb.MovePosition(transform.position + Vector3.left * moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.MovePosition(transform.position + Vector3.right * moveSpeed * Time.deltaTime);
            }
        }
    }
}

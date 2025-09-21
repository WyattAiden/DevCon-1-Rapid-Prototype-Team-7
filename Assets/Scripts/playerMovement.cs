using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody rb;
    //Player move speed
    public float moveSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
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

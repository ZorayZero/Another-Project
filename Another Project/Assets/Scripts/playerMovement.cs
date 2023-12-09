using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("references")]
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 300;
    [SerializeField] Rigidbody rb;
    [SerializeField] bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        vel.y = rb.velocity.y;
        rb.velocity = vel;
       
        // Jump code
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        { rb.AddForce(Vector3.up * jumpForce);  }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }








}

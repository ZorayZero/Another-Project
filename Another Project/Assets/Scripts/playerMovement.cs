using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("references")]
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 3;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void moveInput()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
    }

 
       
}

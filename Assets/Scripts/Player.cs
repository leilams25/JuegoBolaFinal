using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float velocity;
    [SerializeField] float slowTime;
    [SerializeField] float speedTime;
    [SerializeField] float jumpForce = 5f;
    private float puntos = 0;
    private bool isGrounded = true;


    private float zInput;
    private float xInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        ProcesInputs();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  
            isGrounded = false; 
        }

       if (Input.GetKeyDown(KeyCode.E))
        {

            Time.timeScale = Time.timeScale * slowTime;

        }

       else if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = 1f;

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            Time.timeScale = Time.timeScale * speedTime;

        }

        else if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1f;

        }
    }


    private void FixedUpdate()
    {
        Move();
    }

    private void ProcesInputs ()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");


    }

    private void Move()
    {

        rb.AddForce(new Vector3(xInput, 0 , zInput) * velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Pick Up"))
        {
            puntos++;
            other.gameObject.SetActive(false);
        }
    }




}

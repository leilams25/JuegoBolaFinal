using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boudnes : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float BoundForce = 5f;
    [SerializeField] float BoundForceWaterBall = 5f;
    private bool isTouching = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bound"))
        {
         
            rb.AddForce(Vector3.up * BoundForce, ForceMode.Impulse);
            
        }

        if (collision.gameObject.CompareTag("BoundBalls"))
        {

            rb.AddForce(Vector3.up * BoundForceWaterBall, ForceMode.Impulse);

        }
    }


}

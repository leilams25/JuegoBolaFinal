using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPushers : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] float timer2;
    [SerializeField] Vector3 direction;
    [SerializeField] float velocity;
    [SerializeField] float velocityIncrement;

    private Vector3 initialPosition;
    private Vector3 finalPosition;
    void Start()
    {
       initialPosition = transform.position;
       finalPosition = new Vector3(0, 0.004706144f, 0.9f);
    }

    
    void Update()
    {
        

        

        if (timer > 0)
        { 
           // if (transform.position >= finalPosition)
           // {
           //     transform.Translate(new Vector3(0, 0, 0));
           //
           // }
            transform.Translate(finalPosition.normalized * velocity * velocityIncrement * Time.deltaTime);
            timer -= Time.deltaTime;
            
        }
         
        else if (timer2 > 0)
        {
            //if (transform.position = finalPosition)
            //{
            //    transform.Translate(new Vector3(0, 0, 0));
            //
            //}
           
             transform.Translate(finalPosition.normalized * velocity * -1 * Time.deltaTime);
             timer2 -= Time.deltaTime;
             
        }
        else if (timer < 0)
        {
            timer = 0;
            timer2 = 2;

        }
        else if (timer2 < 0)
        {
            timer = 2 / velocityIncrement;
            timer2 = 0;

        }
    }

}

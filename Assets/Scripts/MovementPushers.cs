using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPushers : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] Vector3 direction;
    [SerializeField] float velocity;
    void Start()
    {
       
    }

    
    void Update()
    {
        timer += 1f * Time.deltaTime;

        

        if (timer >= 0 && timer <= 0.35)
        {
            transform.Translate(direction * velocity * Time.deltaTime);

        }

    }
}

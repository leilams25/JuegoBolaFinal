using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float spinSpeed;
    [SerializeField] Vector3 direction;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(direction * spinSpeed * Time.deltaTime);
            
    }
}

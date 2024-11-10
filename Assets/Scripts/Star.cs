using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    public int points = 1;
    public TextMeshProUGUI point;


    private void Start()
    {
        point = GetComponent<TextMeshProUGUI>();



    }
    private void Update()
    {
        Debug.Log("Puntos: " + points);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //points++;

           
            
            Destroy(gameObject);
        }
    }
}

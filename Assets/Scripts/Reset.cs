using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] float final;
    void Update()
    {
       
       
        if (final > player.transform.position.y)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

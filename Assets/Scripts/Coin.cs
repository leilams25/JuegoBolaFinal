using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Player component = other.GetComponent<Player>();
        if (component != null)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

}

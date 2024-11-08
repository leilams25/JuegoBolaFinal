using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    [SerializeField] Button playButton;
    [SerializeField] Button exitButton;
    void Start()
    {
        //playButton.onClick.AddListener(PlayGame);
        //exitButton.onClick.AddListener(ExitGame);
    }
    public void PlayGame()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
       Application.Quit();
               
    }
    
    void Update()
    {
        
    }
}
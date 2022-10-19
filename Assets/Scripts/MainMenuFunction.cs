using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    

    public void PlayGame(){

        buttonPress.Play();
        //takes you to desired level
        //RedirectToLevel.redirectToLevel = 1;
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void PlayCreds(){
        buttonPress.Play();
        SceneManager.LoadScene(3);
        
        
    }

    public void PlayEvenNumberGame(){
    
        SceneManager.LoadScene(2);
    }

    public void Goback(){
        
        SceneManager.LoadScene(4);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EvenRedirect : MonoBehaviour
{
    public void RedirectMenu(){
        SceneManager.LoadScene(3);

    }
    public void RedirectMathGame(){
        SceneManager.LoadScene(0);
    }

    public void RedirectOddGame(){
        SceneManager.LoadScene(5);
    }
    public void RedirectEvenGame(){
        SceneManager.LoadScene(1);
    }
    public void ShapeIdentificationGame(){
        SceneManager.LoadScene(4);
    }
}

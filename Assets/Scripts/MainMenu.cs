using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


    public void PlayGame()
    {
        print("play");
        //SceneManager.LoadSceneAsync(1);
    }




    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}



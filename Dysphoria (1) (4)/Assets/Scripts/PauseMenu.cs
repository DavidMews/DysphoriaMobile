using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject inventarUI;
    public GameObject demonmodebg;
    public GameObject demonModeButton;
    public GameObject inventarButton;
    public GameObject pauseMenuUI;
    bool gameIsPaused;
    private DialogManager dia;
    // Start is called before the first frame update
    void Start()
    {
        dia = FindObjectOfType<DialogManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        dia.inDialog = true;
        inventarUI.SetActive(false);
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            demonModeButton.SetActive(false);
            demonmodebg.SetActive(false);
        }
        inventarButton.SetActive(false);
        pauseMenuUI.SetActive(true);
       
        gameIsPaused = true;
    }
    public void Resume()
    {
        inventarUI.SetActive(true);
        inventarButton.SetActive(true);
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            demonModeButton.SetActive(true);
            demonmodebg.SetActive(true);
        }
        pauseMenuUI.SetActive(false);
        dia.inDialog = false;
        gameIsPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

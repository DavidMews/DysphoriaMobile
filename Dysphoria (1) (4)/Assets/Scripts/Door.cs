using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] string goToLevel;
    [SerializeField] GameObject blackScreen;
    [SerializeField] GameObject fadeToNormal;
    private DialogManager dialogManager;

    private void Awake()
    {
        dialogManager = FindObjectOfType<DialogManager>();
        fadeToNormal.SetActive(true);
        blackScreen.SetActive(false);

        // fadeToNormal deaktivieren damit kein Image im Foreground liegt
        StartCoroutine("DeactivateFadeToNormal");
    }


    IEnumerator DeactivateFadeToNormal()
    {
        yield return new WaitForSeconds(2f);
        fadeToNormal.SetActive(false);
    }

    // beim klicken auf Tür -> Szenenwechsel nach 2 Sekunden
    private void OnMouseDown()
    {
        if (dialogManager.inDialog == false)
        {
            StartCoroutine("Szenenwechsel");
        }
        
    }

    public void SceneWechselButton()
    {
        if (dialogManager.inDialog == false)
        {
            StartCoroutine("Szenenwechsel");
        }
    }

    public void StartCutsceneScene()
    {
        StartCoroutine("Szenenwechsel");
    }

    public void LoadGame()
    {
        StartCoroutine("Szenenwechsel");
    }


    IEnumerator Szenenwechsel()
    {
        PlayerPrefs.SetString("thisScene", SceneManager.GetActiveScene().name);
        blackScreen.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(goToLevel);
    }
}

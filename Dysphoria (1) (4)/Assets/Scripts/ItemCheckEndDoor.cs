using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCheckEndDoor : MonoBehaviour
{

  

    [SerializeField] GameObject gimmeBoi;
    [SerializeField] GameObject teddy;
    [SerializeField] GameObject sword;
    [SerializeField] GameObject actionFigure;
    [SerializeField] GameObject fireTruck;

    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject fadeToBlack;

    Inventory inventory;

    private LoadItem loadItem;

 

    private AudioSource audioSource;

    private DemonMode demonMode;
    private bool credits;
   

    private void Start()
    {
        inventory = Inventory.instance;
        loadItem = FindObjectOfType<LoadItem>();

        audioSource = GetComponent<AudioSource>();
        demonMode = FindObjectOfType<DemonMode>();
        gimmeBoi.SetActive(false);
        teddy.SetActive(false);
        sword.SetActive(false);
        actionFigure.SetActive(false);
        fireTruck.SetActive(false);
        
        credits = true;
    }

    private void Update()
    {
    

        if (PlayerPrefs.GetInt("GimmeBoiInDoor") == 1
            && PlayerPrefs.GetInt("TeddyInDoor") == 1
            && PlayerPrefs.GetInt("SchwertInDoor") == 1
            && PlayerPrefs.GetInt("ActionInDoor") == 1
            && PlayerPrefs.GetInt("FeuerInDoor") == 1
            && credits == true)
        {
            ShowCredits();           
        }

        if (demonMode.inDemonMode == false)
        {
            foreach (GameObject button in buttons)
            {
                button.SetActive(false);
            }

            gimmeBoi.SetActive(false);
            teddy.SetActive(false);
            sword.SetActive(false);
            actionFigure.SetActive(false);
            fireTruck.SetActive(false);
        }
        else if (demonMode.inDemonMode == true)
        {
            foreach (GameObject button in buttons)
            {
                button.SetActive(true);
            }

            if (PlayerPrefs.GetInt("GimmeBoiInDoor") == 1)
            {
                gimmeBoi.SetActive(true);
            }
            if (PlayerPrefs.GetInt("TeddyInDoor") == 1)
            {
                teddy.SetActive(true);
            }
            if (PlayerPrefs.GetInt("SchwertInDoor") == 1)
            {
                sword.SetActive(true);
            }
            if (PlayerPrefs.GetInt("ActionInDoor") == 1)
            {
                actionFigure.SetActive(true);
            }
            if (PlayerPrefs.GetInt("FeuerInDoor") == 1)
            {
                fireTruck.SetActive(true);
            }
        }

    }


    void ShowCredits()
    {
        audioSource.Play();
        StartCoroutine("StartCredits");  
        credits = false;
    }

    IEnumerator StartCredits()
    {
        
        fadeToBlack.SetActive(true);
        yield return new WaitForSecondsRealtime(4f);
        SceneManager.LoadScene("ComingSoon");
    }


    public void GiveMeGimmeBoi()
    {
        if (PlayerPrefs.GetInt("GimmeBoiComplete") == 1)
        {
            gimmeBoi.SetActive(true);
            PlayerPrefs.SetInt("GimmeBoiInDoor", 1);
            Inventory.instance.Remove(loadItem.completeGimmeBoi);
            PlayerPrefs.SetInt("Batterie",0);
            PlayerPrefs.SetInt("GimmeBoi",0);
            PlayerPrefs.SetInt("GimmeBoiComplete", 0);
           
        }
    }

    public void GiveMeTeddy()
    {
        if (PlayerPrefs.GetInt("Teddy") == 1)
        {
            teddy.SetActive(true);
            PlayerPrefs.SetInt("TeddyInDoor", 1);
            Inventory.instance.Remove(loadItem.teddy);
            PlayerPrefs.SetInt("Teddy", 0);   
        }
    }

    public void GiveMeSword()
    {
        if (PlayerPrefs.GetInt("SchwertComplete") == 1)
        {
            sword.SetActive(true);
            PlayerPrefs.SetInt("SchwertInDoor", 1);
            Inventory.instance.Remove(loadItem.completeSword);
            PlayerPrefs.SetInt("Gem",0);
            PlayerPrefs.SetInt("Schwert",0);
            PlayerPrefs.SetInt("SchwertComplete",0);          
        }
    }

    public void GiveMeActionFigure()
    {
        if (PlayerPrefs.GetInt("ActionFigure") == 1)
        {
            actionFigure.SetActive(true);
            PlayerPrefs.SetInt("ActionInDoor", 1);
            Inventory.instance.Remove(loadItem.actionFigure);
            PlayerPrefs.SetInt("ActionFigure", 0);   
        }
    }

    public void GiveMeFireTruck()
    {
        if (PlayerPrefs.GetInt("FeuerautoComplete") == 1)
        {
            fireTruck.SetActive(true);
            PlayerPrefs.SetInt("FeuerInDoor", 1);
            Inventory.instance.Remove(loadItem.completeFiretruck);
            PlayerPrefs.SetInt("Reifen", 0);
            PlayerPrefs.SetInt("Feuerauto", 0);
            PlayerPrefs.SetInt("FeuerautoComplete", 0);     
        }
    }


}

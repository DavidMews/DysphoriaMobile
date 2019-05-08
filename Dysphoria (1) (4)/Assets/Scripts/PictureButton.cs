using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureButton : MonoBehaviour
{
    public GameObject exit;
    public GameObject transButton;
    private DialogManager dia;
    public GameObject Canvas;
    public GameObject exitButton;
    public GameObject backButton;
    public Image picture;
    public GameObject button;
    public GameObject buttonGrid;
    public Sprite familyPicture;
    public Sprite safe1;
    public Sprite safe2;
    public Sprite safe3;
    public Sprite safe4;
    private bool isenabled = false;
    private void Awake()
    {
        picture = GetComponent<Image>();
        picture.sprite = familyPicture;
        dia = FindObjectOfType<DialogManager>();
    }

    private void OnEnable()
    {
     
        if (PlayerPrefs.GetInt("Gem") == 1||PlayerPrefs.GetInt("SchwertInDoor") == 1)
        {
           
            picture.sprite = safe4;
            transButton.SetActive(false);
            dia.inDialog = false;
            exit.SetActive(true);
            
        }
    }



    public void ExitCode()
    {

        gameObject.SetActive(false);
        backButton.SetActive(false);
        Canvas.SetActive(true);
        dia.inDialog = false;

    }
   


    public void Exit()
    {
        if (picture.sprite==safe4)
        {
            gameObject.SetActive(false);
            exitButton.SetActive(false);
            Canvas.SetActive(true);
            dia.inDialog = false;
           


        }
    }
    public void Exit2()
    {
        
        gameObject.SetActive(false);
        exitButton.SetActive(false);
        Canvas.SetActive(true);
        dia.inDialog = false;
    }

    public void Button()
    {
        if (PlayerPrefs.GetInt("Gem")==0)
        {


            if (picture.sprite == familyPicture)
            {
                picture.sprite = safe1;
            }
            else if (picture.sprite == safe1)
            {

                picture.sprite = safe2;
                button.SetActive(false);
                backButton.SetActive(true);
                buttonGrid.SetActive(true);
            }

        }
     
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActionFigure : MonoBehaviour
{

    public bool onFloor;
    private DialogManager dialogManager;
    private DialogTrigger dialogTrigger;
  
    


    private void Awake()
    {
        if (PlayerPrefs.GetInt("ActionFigure") == 1|| PlayerPrefs.GetInt("ActionInDoor") == 1)
        {
            Destroy(gameObject);
        }
      
        dialogManager = FindObjectOfType<DialogManager>();
        dialogTrigger = GetComponent<DialogTrigger>();
    
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (onFloor == true && PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            PlayerPrefs.SetInt("ActionFigure", 1);
        }
    }


}

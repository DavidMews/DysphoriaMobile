using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewusstlosigkeit : MonoBehaviour
{

    private DialogTrigger dialogTrigger;
    private DialogManager dialogManager;



    void Start()
    {
        dialogTrigger = GetComponent<DialogTrigger>();
        dialogManager = FindObjectOfType<DialogManager>();

        if (PlayerPrefs.GetInt("Bewusstlos") == 1)
        {
            dialogManager.StartDialog(dialogTrigger.dialog[0]);
            PlayerPrefs.SetInt("Bewusstlos", 0);
        }


    }

}

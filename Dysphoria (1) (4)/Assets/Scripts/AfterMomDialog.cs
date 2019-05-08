using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterMomDialog : MonoBehaviour
{
    private DialogTrigger dialogTrigger;
    private DialogManager dialogManager;
    [SerializeField] GameObject mom;

    public DialogTrigger dialogMaddie;
    public DialogTrigger dialogDemon;

    private DontShowDemon dontShowDemon;

    private void Awake()
    {
        dontShowDemon = FindObjectOfType<DontShowDemon>();
        dialogManager = FindObjectOfType<DialogManager>();
        dialogTrigger = mom.GetComponent<DialogTrigger>();
    }

    private void Update()
    {

        if (PlayerPrefs.GetInt("DontShowAfterMomDialog") == 0)
        {
            if (PlayerPrefs.GetInt("StartAfterMomDialog") == 1)
            {
                dialogManager.StartDialog(dialogTrigger.dialog[2]);
                PlayerPrefs.SetInt("DontShowAfterMomDialog", 1);
            }
        }


        if (PlayerPrefs.GetInt("EndDialog") == 0)
        {
            if (PlayerPrefs.GetInt("QuestDia") == 1)
            {
                dialogManager.StartDialog(dialogDemon.dialog[0]);
                PlayerPrefs.SetInt("EndDialog", 1);
            }

            if (PlayerPrefs.GetInt("QuestDia") == 2)
            {
                dialogManager.StartDialog(dialogMaddie.dialog[0]);
                PlayerPrefs.SetInt("EndDialog", 1);
            }

            if (PlayerPrefs.GetInt("QuestDia") == 3)
            {
                dialogManager.StartDialog(dialogDemon.dialog[1]);
                PlayerPrefs.SetInt("EndDialog", 1);
                dontShowDemon.ActivateDemonIcon();
            }
        }
       

       
    }
}
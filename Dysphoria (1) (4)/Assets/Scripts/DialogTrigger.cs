using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogTrigger : MonoBehaviour
{
    [Header("Dialog 3, falls man nicht bei Mom war")]
    [Header("Bei keiner Ruckantwort ersten dialog kopieren")]
    [Header("IMMER 3 DIALOGE EINSTELLEN")]
    public Dialog[] dialog;
    private AudioSource audioSource;
    private DialogManager dialogManager;
    private Player player;

    

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        audioSource = GetComponent<AudioSource>();
        dialogManager = FindObjectOfType<DialogManager>();
    }

  
    public void TriggerDialog()
    {
        if (dialogManager.inDialog == false)
        {
            if (PlayerPrefs.GetInt("HasTalkedToMom") != 1 && dialog[2] != null)
            {
                dialogManager.StartDialog(dialog[2]);
                return;
            }

            dialogManager.StartDialog(dialog[0]);
            if (audioSource != null)
            {
                audioSource.Play();
            }

            if (dialog.Length > 1 && dialogManager.readyForAnswer == true)
            {
                dialogManager.StartDialog(dialog[1]);
            }
        }
        
        
    }

    private void OnMouseDown()
    {

      
        if (dialogManager.inDialog == false)
        {
            if (PlayerPrefs.GetInt("HasTalkedToMom") != 1 && dialog[2] != null)
            {
                dialogManager.StartDialog(dialog[2]);
                return;
            }

            dialogManager.StartDialog(dialog[0]);
            if (audioSource != null)
            {
                audioSource.Play();
            }

            if (dialog.Length > 1 && dialogManager.readyForAnswer == true)
            {
                dialogManager.StartDialog(dialog[1]);
            }
        }

        
    }

}

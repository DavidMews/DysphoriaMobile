using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Besen : MonoBehaviour
{
    private DemonMode demonMode;
    private DialogManager dialogManager;
    private DialogTrigger dialogTrigger;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Besen") == 1)
        {
            Destroy(gameObject);
        }

        demonMode = FindObjectOfType<DemonMode>();
        dialogManager = FindObjectOfType<DialogManager>();
        dialogTrigger = GetComponent<DialogTrigger>();
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (demonMode.inDemonMode)
        {
            PlayerPrefs.SetInt("Besen", 1);
        }
        else
        {
            dialogManager.StartDialog(dialogTrigger.dialog[0]);
        }
    }
}

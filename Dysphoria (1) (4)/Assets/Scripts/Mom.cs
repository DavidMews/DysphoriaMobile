using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : MonoBehaviour
{

    private DialogManager dialogManager;

    private void Awake()
    {
        dialogManager = FindObjectOfType<DialogManager>();
    }

    private void OnMouseDown()
    {
        PlayerPrefs.SetInt("HasTalkedToMom", 1);
     
    }
}

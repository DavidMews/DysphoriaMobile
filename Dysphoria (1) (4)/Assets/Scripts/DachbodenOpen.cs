using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DachbodenOpen : MonoBehaviour
{

    [SerializeField] GameObject unlockedDachboden;
    private DialogManager dialogManager;


    private void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();

        if (PlayerPrefs.GetInt("DachbodenOpen") == 1)
        {
            unlockedDachboden.SetActive(true);
            gameObject.SetActive(false);
        }
    }


    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("BesenComplete") == 1)
        {
            PlayerPrefs.SetInt("DachbodenOpen", 1);
            unlockedDachboden.SetActive(true);
            gameObject.SetActive(false);
            dialogManager.StopAllCoroutines();
            dialogManager.EndDialog();
            
        }
    }

}

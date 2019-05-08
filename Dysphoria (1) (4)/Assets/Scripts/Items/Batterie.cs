using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Batterie : MonoBehaviour
{

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Batterie") == 1 || PlayerPrefs.GetInt("GimmeBoiInDoor") == 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            PlayerPrefs.SetInt("Batterie", 1);

        }       
    }
}

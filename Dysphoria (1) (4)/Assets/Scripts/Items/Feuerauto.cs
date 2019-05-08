using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Feuerauto : MonoBehaviour
{

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Feuerauto") == 1 || PlayerPrefs.GetInt("FeuerInDoor") == 1)
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
            PlayerPrefs.SetInt("Feuerauto", 1);
        }
            
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kleiderbugel : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Kleiderbugel") == 1)
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
            PlayerPrefs.SetInt("Kleiderbugel", 1);
        }
            
    }
}

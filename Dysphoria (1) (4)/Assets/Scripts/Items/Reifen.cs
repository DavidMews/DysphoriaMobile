using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Reifen : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Reifen") == 1 || PlayerPrefs.GetInt("FeuerInDoor") == 1)
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
            PlayerPrefs.SetInt("Reifen", 1);
        }
    }
}

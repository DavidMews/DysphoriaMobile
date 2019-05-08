using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Schwert : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Schwert") == 1||PlayerPrefs.GetInt("SchwertInDoor") ==1)
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
            PlayerPrefs.SetInt("Schwert", 1);

        }
    }
}

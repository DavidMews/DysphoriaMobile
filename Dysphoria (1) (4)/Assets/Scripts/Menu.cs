using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject LoadButton;

    private void Start()
    {
        if (PlayerPrefs.GetInt("HasClothes") != 0)
        {
            LoadButton.SetActive(true);
        }
        else
        {
            LoadButton.SetActive(false);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPanel : MonoBehaviour
{
    [SerializeField] GameObject firstPanel;

    private void Start()
    {
        if (PlayerPrefs.GetInt("HasClothes") == 0)
        {
            firstPanel.SetActive(true);
        }
    }

}

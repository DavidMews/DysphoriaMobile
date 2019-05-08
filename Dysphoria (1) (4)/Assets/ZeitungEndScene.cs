using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitungEndScene : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] GameObject comingSoon;
    [SerializeField] GameObject backButton;

    public void ClosePanel()
    {
        comingSoon.SetActive(true);
        backButton.SetActive(false);
        panel.SetActive(false);
        

    }


}

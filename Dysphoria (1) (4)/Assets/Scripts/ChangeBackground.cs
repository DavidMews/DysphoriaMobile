using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{

    [SerializeField] GameObject normalBG;
    [SerializeField] GameObject demonBG;

    private DemonMode demonMode;

    private void Start()
    {
        demonMode = FindObjectOfType<DemonMode>();
    }

    private void Update()
    {    
        if (demonMode.inDemonMode == true)
        {
            normalBG.SetActive(false);
            demonBG.SetActive(true);
        }
        else if (demonMode.inDemonMode == false)
        {
            normalBG.SetActive(true);
            demonBG.SetActive(false);
        }

    }


}



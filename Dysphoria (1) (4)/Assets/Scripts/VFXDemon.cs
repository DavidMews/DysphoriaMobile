using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXDemon : MonoBehaviour
{

    private DemonMode demonMode;
    public GameObject[] VFX;


    private void Start()
    {
        demonMode = FindObjectOfType<DemonMode>();
    }

    private void Update()
    {
        if (demonMode.inDemonMode)
        {
            foreach (GameObject vfx in VFX)
            {
                vfx.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject vfx in VFX)
            {
                vfx.SetActive(false);
            }
        }
    }


}

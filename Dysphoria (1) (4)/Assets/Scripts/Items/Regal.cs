using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regal : MonoBehaviour
{

    private DemonMode demonMode;
    public GameObject actionFigure;
    private ActionFigure actionFigureScript;
    private Animator anim;


    private void Awake()
    {
        demonMode = FindObjectOfType<DemonMode>();   
    }

    private void Start()
    {
        actionFigureScript = actionFigure.GetComponent<ActionFigure>();
        anim = actionFigure.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (demonMode.inDemonMode)
        {
            actionFigureScript.onFloor = true;
            anim.enabled = true;
        }
    }
}

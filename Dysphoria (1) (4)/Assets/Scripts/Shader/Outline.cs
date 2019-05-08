using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline : MonoBehaviour
{
    public Material outlineC;
    
    // Start is called before the first frame update
    void Start()
    {

        outlineC.SetColor("_Color", Color.white);
        
    }

    private void OnMouseEnter()
    {
        outlineC.SetColor("_Color", Color.red);
        
    }

    private void OnMouseExit()
    {
        outlineC.SetColor("_Color", Color.white);
    }

}

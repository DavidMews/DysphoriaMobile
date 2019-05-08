using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventarSelect : MonoBehaviour, IPointerClickHandler
{

    private Test test;
    

    // Start is called before the first frame update
    void Awake()
    {
        test = FindObjectOfType<Test>();
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        
        test.selectedSlot = gameObject;
        Debug.Log(test.selectedSlot.name);
        
    }
}

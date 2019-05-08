using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PictureTrigger : MonoBehaviour
{
   
    public GameObject pictureFamily;
    public GameObject canvas;
   

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

      
        pictureFamily.SetActive(true);
        canvas.SetActive(false);  
    }




}

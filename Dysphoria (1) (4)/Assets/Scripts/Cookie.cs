using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cookie : MonoBehaviour
{
    public GameObject cookieJar;
    public GameObject gimmeBoi;
    public GameObject cookies;
    private SpriteRenderer rend;
    public Sprite cookieClosed;
    public Sprite cookieOpen;


    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
 
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            rend.sprite = cookieOpen;
            if (cookies != null)
            {
                cookies.SetActive(true);
            }
        }


       
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}

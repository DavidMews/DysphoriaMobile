using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Zeitung : MonoBehaviour
{

    [SerializeField] GameObject zeitungsPanel;
    private DialogManager dialogManager;
    private Animator anim;
    private bool open;

    private void Start()
    {
        zeitungsPanel.SetActive(false);
        dialogManager = FindObjectOfType<DialogManager>();
        anim = zeitungsPanel.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (open == false)
        {
            dialogManager.inDialog = true;
            zeitungsPanel.SetActive(true);
            anim.SetBool("closing", false);
            open = true;
        }     
    }

    public void ClosePanel()
    {
        dialogManager.inDialog = false;
        anim.SetBool("closing", true);
        open = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemBesen : MonoBehaviour
{
    public ItemBlueprint item;
    public Material outlineC;

    private DemonMode demonMode;

    private void Start()
    {
        demonMode = FindObjectOfType<DemonMode>();
        outlineC.SetColor("_Color", Color.black);
    }


    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (demonMode.inDemonMode)
        {
            outlineC.SetColor("_Color", Color.red);
        }
        else
        {
            outlineC.SetColor("_Color", Color.black);
        }


    }

    private void OnMouseExit()
    {
        outlineC.SetColor("_Color", Color.black);
    }



    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        PickUp();
    }

    void PickUp()
    {
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1 && demonMode.inDemonMode)
        {
            Debug.Log("Picking up " + item.name);
            bool wasPickedUp = Inventory.instance.Add(item);
            if (wasPickedUp)
            {
                Destroy(gameObject);
            }
        }



    }
}

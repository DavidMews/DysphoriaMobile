using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GimmeboiPickUp : MonoBehaviour
{
    public ItemBlueprint item;
    public Material outlineC;

    private DemonMode demonMode;
    private Player player;

    private DialogManager dialogManager;
    [SerializeField] GameObject cookieDialog;
    private DialogTrigger dialogTrigger;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("GimmeBoi") == 1 || PlayerPrefs.GetInt("GimmeBoiInDoor") == 1)
        {
            Destroy(gameObject);
        }
        player = FindObjectOfType<Player>();
        demonMode = FindObjectOfType<DemonMode>();
    }
    private void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
        dialogTrigger = cookieDialog.GetComponent<DialogTrigger>();
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
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            PlayerPrefs.SetInt("GimmeBoi", 1);
            PickUp();
        }
    }

    void PickUp()
    {
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            dialogManager.StartDialog(dialogTrigger.dialog[1]);
            player.isGrabbing = true;
            Debug.Log("Picking up " + item.name);
            bool wasPickedUp = Inventory.instance.Add(item);
            if (wasPickedUp)
            {
                Destroy(gameObject);
            }
        }
    }
}

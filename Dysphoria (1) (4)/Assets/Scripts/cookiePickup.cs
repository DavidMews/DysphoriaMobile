using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class cookiePickup : MonoBehaviour
{
    public ItemBlueprint item;
    public Material outlineC;

    private DemonMode demonMode;
    private Player player;

    public GameObject gimmeBoi;
    private SpriteRenderer cookierend;
    public Sprite cookie1;
    public Sprite cookie2;
    public Sprite cookie3;

    private DialogManager dialogManager;
    private AudioSource audio;

    [SerializeField] GameObject CookieDialog;
    private DialogTrigger dialogTrigger;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Cookie")==1)
        {
            Destroy(gameObject);
        }

        player = FindObjectOfType<Player>();
        demonMode = FindObjectOfType<DemonMode>();
        cookierend = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        dialogManager = FindObjectOfType<DialogManager>();
        dialogTrigger = CookieDialog.GetComponent<DialogTrigger>();
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
            player.isGrabbing = true;
            if (cookierend.sprite == cookie3)
            {
                dialogManager.StartDialog(dialogTrigger.dialog[0]);
                cookierend.sprite = cookie2;
                audio.Play();
            }
            else if (cookierend.sprite == cookie2)
            {
                dialogManager.StartDialog(dialogTrigger.dialog[0]);
                cookierend.sprite = cookie1;
                audio.Play();
            }
            else if (cookierend.sprite == cookie1)
            {
                dialogManager.StartDialog(dialogTrigger.dialog[0]);
                audio.Play();
                PlayerPrefs.SetInt("Cookie", 1);
                PickUp();
                if (gimmeBoi != null)
                {
                    gimmeBoi.SetActive(true);
                }
                
                gameObject.SetActive(false);
            }
        }
    }

    void PickUp()
    {
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HamsterCage : MonoBehaviour
{

    [SerializeField] GameObject hamsterCage;
    [SerializeField] Sprite lockedCage;
    [SerializeField] Sprite unlockedCage;

    private SpriteRenderer spriteRenderer;
    private DialogTrigger dialog;
    private DialogManager dialogManager;

    public ItemBlueprint item;
    private AudioSource audio;

 

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        dialogManager = FindObjectOfType<DialogManager>();
        dialog = GetComponent<DialogTrigger>();
        spriteRenderer = hamsterCage.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = lockedCage;

        if (PlayerPrefs.GetInt("CageUnlocked") == 1||PlayerPrefs.GetInt("TeddyInDoor") == 1)
        {
            spriteRenderer.sprite = unlockedCage;
        }
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (PlayerPrefs.GetInt("CageUnlocked") == 1)
        {
            dialogManager.StartDialog(dialog.dialog[3]);
        }
        else if (PlayerPrefs.GetInt("Key") == 0)
        {
            dialogManager.StartDialog(dialog.dialog[0]);
            audio.Play();
        }
        else if (PlayerPrefs.GetInt("Key") == 1 && PlayerPrefs.GetInt("Cookie") == 0)
        {
            dialogManager.StartDialog(dialog.dialog[1]);
            audio.Play();
        }
        else if (PlayerPrefs.GetInt("Key") == 1 && PlayerPrefs.GetInt("Cookie") == 1)
        {
            dialogManager.StartDialog(dialog.dialog[2]);
            spriteRenderer.sprite = unlockedCage;
            PlayerPrefs.SetInt("CageUnlocked", 1);
            PlayerPrefs.SetInt("Teddy", 1);

            Debug.Log("Picking up " + item.name);
            bool wasPickedUp = Inventory.instance.Add(item);

        }

        
    }
}

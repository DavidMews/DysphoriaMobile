using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clothes : MonoBehaviour
{
    private QuestTrigger questTrigger;
    [SerializeField] GameObject player;
    private SpriteRenderer playerSprite;
    private Player playerModel;
    [SerializeField] Sprite normalSprite;
    [SerializeField] Sprite oldClothes;

    private AudioSource audioSource;

    private void Awake()
    {
        questTrigger = FindObjectOfType<QuestTrigger>();
        playerModel = FindObjectOfType<Player>();
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("HasClothes") != 1)
        {
            playerModel.hasClothes = false;
        }
        else
        {
            playerModel.hasClothes = true;
            questTrigger.ActivateDoor();
            Destroy(gameObject);
        }
    }

    public void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        playerModel.hasClothes = true;
        questTrigger.ActivateDoor();
        audioSource.Play();
        PlayerPrefs.SetInt("HasClothes", 1);
        Destroy(gameObject, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JackBox : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private Image panelImage;
    [SerializeField] Sprite firstImage;
    [SerializeField] Sprite secondImage;
    [SerializeField] Sprite noKeyImage;
    [SerializeField] AudioClip jumpScare;
    [SerializeField] AudioClip music;

    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite jackBoxOpen;

    private Animator anim;
    private AudioSource audioSource;

    [SerializeField] ItemBlueprint item;

    private void Start()
    {


        spriteRenderer = GetComponent<SpriteRenderer>();
        panelImage = panel.GetComponent<Image>();
        anim = panel.GetComponent<Animator>();
        audioSource = panel.GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("HasTalkedToMom") != 1)
        {
            gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Key") == 1)
        {
            spriteRenderer.sprite = jackBoxOpen;
        }
    }


    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        audioSource.clip = music;
        panel.SetActive(true);
        panelImage.sprite = firstImage;
        if (audioSource != null)
        {         
            audioSource.Play();
        }
        anim.SetBool("isOpen", true);
    }

    public void NextImage()
    {
        audioSource.Stop();

        if (PlayerPrefs.GetInt("Key") == 0)
        {
            bool wasPickedUp = Inventory.instance.Add(item);
        }


        if (panelImage.sprite == firstImage && PlayerPrefs.GetInt("Key") == 0)
        {
            if (audioSource != null)
            {
                audioSource.clip = jumpScare;
                audioSource.Play();
            }
            spriteRenderer.sprite = jackBoxOpen;
            panelImage.sprite = secondImage;
            PlayerPrefs.SetInt("Key", 1);
        }
        else if (panelImage.sprite == firstImage && PlayerPrefs.GetInt("Key") == 1)
        {
            panelImage.sprite = noKeyImage;
        }
        else
        {
            DeactivatePanel();
        }

    }


    public void DeactivatePanel()
    {
        anim.SetBool("isOpen", false);

        //panel.SetActive(false);
    }

}

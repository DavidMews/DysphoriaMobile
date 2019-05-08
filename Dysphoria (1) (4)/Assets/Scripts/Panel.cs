using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{

    [SerializeField] GameObject panel;
    private Image panelImage;
    [SerializeField] Sprite firstImage;
    [SerializeField] Sprite secondImage;
    private Animator anim;
    private AudioSource audioSource;

    private void Awake()
    {
        panelImage = panel.GetComponent<Image>();
        anim = panel.GetComponent<Animator>();
        audioSource = panel.GetComponent<AudioSource>();
    }


    private void OnMouseDown()
    {   

        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {

            panel.SetActive(true);
            panelImage.sprite = firstImage;
            if (audioSource != null)
            {
                audioSource.Play();
            }
            anim.SetBool("isOpen", true);
        }

    }

    public void NextImage()
    {
        if (panelImage.sprite == firstImage)
        {
            if (audioSource != null)
                audioSource.Play();
            panelImage.sprite = secondImage;
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

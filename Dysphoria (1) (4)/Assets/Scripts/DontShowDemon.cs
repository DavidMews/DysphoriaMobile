using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontShowDemon : MonoBehaviour
{

    [SerializeField] GameObject demonIcon;
    [SerializeField] GameObject demonIconBG;
    private Button demonButton;
    private Image image;

    private void Start()
    {
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 0)
        {
            demonIconBG.SetActive(false);
            demonButton = demonIcon.GetComponent<Button>();
            image = demonIcon.GetComponent<Image>();
            image.enabled = false;
            demonButton.enabled = false;
        }

    }


    public void ActivateDemonIcon()
    {
        demonIconBG.SetActive(true);
        image.enabled = true;
        demonButton.enabled = true;
    }


}

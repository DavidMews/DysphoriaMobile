using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public ItemBlueprint item;
    public Material outlineC;

    private DemonMode demonMode;
    private Player player;

    private PictureButton pic;
    public GameObject exitButton;
    public GameObject UI;

    private void Start()
    {
        pic = FindObjectOfType<PictureButton>();
        player = FindObjectOfType<Player>();
      
    }
    void PickUp()
    {
       
            player.isGrabbing = true;
            Debug.Log("Picking up " + item.name);
            bool wasPickedUp = Inventory.instance.Add(item);
       

        




    }



    public void Gem()
    {
        PlayerPrefs.SetInt("Gem", 1);
        PickUp();
        pic.picture.sprite = pic.safe4;
        exitButton.SetActive(true);
        gameObject.SetActive(false);
        


    }
}

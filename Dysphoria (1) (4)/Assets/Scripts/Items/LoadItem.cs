using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadItem : MonoBehaviour
{


    public ItemBlueprint fireTruck;
    public ItemBlueprint actionFigure;
    public ItemBlueprint batterie;
    public ItemBlueprint broom;
    public ItemBlueprint cookie; 
    public ItemBlueprint gem;
    public ItemBlueprint gimmeBoi;
    public ItemBlueprint hanger;
    public ItemBlueprint key;
    public ItemBlueprint sword;
    public ItemBlueprint teddy;
    public ItemBlueprint tire;
    public ItemBlueprint completeFiretruck;
    public ItemBlueprint completeSword;
    public ItemBlueprint completeGimmeBoi;
    public ItemBlueprint completeBroom;
    

    private InventoryUI inventoryUI;
    private Inventory inventory;

    void Start()
    {
        inventoryUI = FindObjectOfType<InventoryUI>();
        inventory = FindObjectOfType<Inventory>();



        
        if (PlayerPrefs.GetInt("SchwertComplete") == 1) { inventory.items.Add(completeSword); }
        if (PlayerPrefs.GetInt("SchwertComplete") == 0)
        {
            if (PlayerPrefs.GetInt("Gem") == 1) { inventory.items.Add(gem); }
            if (PlayerPrefs.GetInt("Schwert") == 1) { inventory.items.Add(sword); }
        }
           

        if (PlayerPrefs.GetInt("GimmeBoiComplete") == 1) { inventory.items.Add(completeGimmeBoi); }
        if (PlayerPrefs.GetInt("GimmeBoiComplete") == 0)
        {
            if (PlayerPrefs.GetInt("Batterie") == 1) { inventory.items.Add(batterie); }
            if (PlayerPrefs.GetInt("GimmeBoi") == 1) { inventory.items.Add(gimmeBoi); }
        }

            
        if (PlayerPrefs.GetInt("BesenComplete") == 1) { inventory.items.Add(completeBroom); }
        if (PlayerPrefs.GetInt("BesenComplete") == 0)
        {
            if (PlayerPrefs.GetInt("Besen") == 1) { inventory.items.Add(broom); }
            if (PlayerPrefs.GetInt("Kleiderbugel") == 1) { inventory.items.Add(hanger); }

        }


        if (PlayerPrefs.GetInt("FeuerautoComplete") == 1) { inventory.items.Add(completeFiretruck); }
        if (PlayerPrefs.GetInt("FeuerautoComplete") == 0)
        {
            if (PlayerPrefs.GetInt("Feuerauto") == 1) { inventory.items.Add(fireTruck); }
            if (PlayerPrefs.GetInt("Reifen") == 1) { inventory.items.Add(tire); }
        }

        if (PlayerPrefs.GetInt("Teddy") == 1) { inventory.items.Add(teddy); }
        if (PlayerPrefs.GetInt("Teddy") == 0)
        {
            if (PlayerPrefs.GetInt("Cookie") == 1) { inventory.items.Add(cookie); }           
        }

        if (PlayerPrefs.GetInt("Key") == 1) { inventory.items.Add(key); }
        if (PlayerPrefs.GetInt("ActionFigure") == 1) { inventory.items.Add(actionFigure); }
       
        inventoryUI.UpdateUI();
    }  
}

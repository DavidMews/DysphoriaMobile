using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singelton
    public static Inventory instance;


     void Awake()
     {
        if (instance !=null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;  
     }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    
    public int space = 8;

    public List<ItemBlueprint> items = new List<ItemBlueprint>();

   


    public bool Add(ItemBlueprint item)
    {

        if (items.Count >= space)
        {
            Debug.Log("Not enough room");
                return false;
        }
        else
        {
            items.Add(item);
            
            if (onItemChangedCallback !=null)
            {
                onItemChangedCallback.Invoke();
            }
           


        }
            
        return true;
        


    }

    public void Remove(ItemBlueprint item)
    {

        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

    }
   



}

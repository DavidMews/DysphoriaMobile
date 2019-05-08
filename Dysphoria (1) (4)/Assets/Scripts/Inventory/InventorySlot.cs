using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventorySlot : MonoBehaviour
{
    public Text text;
    public GameObject panel;
    private Test test;

    public Image icon;
    ItemBlueprint item;

    bool interfaceEnabled;

    public GameObject selectedSlot;

    

    Inventory inventory;


    List<string> CombineAbleItems = new List<string> {
     "Sword"+"Gem","Gem"+"Sword",
     "Hanger" +"Broom","Broom" +"Hanger",
     "GimmeBoi"+"Batterie","Batterie"+"GimmeBoi",
     "Tire"+"FirefighterTruck","FirefighterTruck"+"Tire"



    };
     







    public void Start()
    {
        test = FindObjectOfType<Test>();
        inventory = Inventory.instance;
        
    }

    public void Update()
    {

        Checkcombinatiion();
        
             
      
       
        if (Input.GetKey(KeyCode.LeftShift)&& panel.activeSelf)
        {
            Debug.Log("one:" + test.selectone);
            Debug.Log("two" + test.selecttwo);
           
        }

    }


    public void AddItem(ItemBlueprint newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        item.itemDescription = newItem.itemDescription;
      
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
    }

    public void UseItems() {

        if (test.combine == false&& test.inspect == false)
        {
            text.text = item.itemDescription;
        }


        if (test.inspect==true)
        {
            text.text = item.itemDescription2;
            test.inspect = false;
        }
    }

   


    public void UseItem()
    {
    }
     public void SelectCombine()
     {
         if (test.combine == true)
         {
             if (test.selectone == null)
             {
                test.one = true;
                test.selectone = item.name;
                text.text = test.selectone;
                Debug.Log("selected:" + item.name);
                test.temp1 = item;
                
                return;
             }
              if (test.selecttwo == null&&test.selectone!=null)
             {
                test.two = true;
                test.selecttwo = item.name;
                text.text = test.selectone+"+"+test.selecttwo;
                 Debug.Log("selected:" + item.name);
                test.temp2 = item;
                return;
             }
         }       
     }
   public void Checkcombinatiion()
    {    
           if (test.one == true && test.two == true)
            {


                foreach (string s in CombineAbleItems)
                {
                    if (test.selectone + test.selecttwo == s)
                    {               
                        if (test.selectone + test.selecttwo == "Sword" + "Gem")
                        {
                            Inventory.instance.Add(test.CompleteSword);
                            PlayerPrefs.SetInt("SchwertComplete", 1);
                            text.text = "Created Complete Sword";
                            Inventory.instance.Remove(test.temp1);
                            Inventory.instance.Remove(test.temp2);
                            test.one = false;
                            test.two = false;
                            test.selectone = null;
                            test.selecttwo = null;
                            test.temp1 = null;
                            test.temp2 = null;
                            test.combine = false;
                            return;
                           
                        }
                        else if (test.selectone + test.selecttwo == "Gem" + "Sword")
                        {
                            Inventory.instance.Add(test.CompleteSword);
                            PlayerPrefs.SetInt("SchwertComplete", 1);
                            text.text = "Created Complete Sword";
                            Inventory.instance.Remove(test.temp1);
                            Inventory.instance.Remove(test.temp2);
                            test.one = false;
                            test.two = false;
                            test.selectone = null;
                            test.selecttwo = null;
                            test.temp1 = null;
                            test.temp2 = null;
                            test.combine = false;
                            return;

                        }
                        else if (test.selectone + test.selecttwo == "Hanger" + "Broom")
                        {
                           Inventory.instance.Add(test.CompleteBroom);
                            PlayerPrefs.SetInt("BesenComplete", 1);
                            text.text = "Created Complete Broom";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;

                        }
                        else if (test.selectone + test.selecttwo == "Broom" + "Hanger")
                        {
                           Inventory.instance.Add(test.CompleteBroom);
                            PlayerPrefs.SetInt("BesenComplete", 1);
                            text.text = "Created Complete Broom";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;

                        }    
                        else if (test.selectone + test.selecttwo == "Batterie" + "GimmeBoi")
                        {   
                           Inventory.instance.Add(test.CompleteGimmeBoi);
                        PlayerPrefs.SetInt("GimmeBoiComplete", 1);
                        text.text = "Created Complete GimmeBoi";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;

                        }
                        else if (test.selectone + test.selecttwo == "GimmeBoi" + "Batterie")
                        {
                           Inventory.instance.Add(test.CompleteGimmeBoi);
                        PlayerPrefs.SetInt("GimmeBoiComplete", 1);
                        text.text = "Created Complete GimmeBoi";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;

                        }
                       else if (test.selectone + test.selecttwo == "FirefighterTruck" + "Tire")
                       {
                           Inventory.instance.Add(test.CompleteFireTruck);
                            PlayerPrefs.SetInt("FeuerautoComplete", 1);
                           text.text = "Created Complete FireTruck";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;

                       }
                       else if (test.selectone + test.selecttwo == "Tire" + "FirefighterTruck")
                       {
                           Inventory.instance.Add(test.CompleteFireTruck);
                         PlayerPrefs.SetInt("FeuerautoComplete", 1);
                           text.text = "Created Complete FireTruck";
                           Inventory.instance.Remove(test.temp1);
                           Inventory.instance.Remove(test.temp2);
                           test.one = false;
                           test.two = false;
                           test.selectone = null;
                           test.selecttwo = null;
                           test.temp1 = null;
                           test.temp2 = null;
                           test.combine = false;
                           return;
                       }

                    }
                  else 
                    {
                      test.combine = false;
                      text.text = "Wrong Combination";
                      test.one = false;
                      test.two = false;
                    }
                }
           }
   }

    public void CombineItem()
    {
        test.one = false;
        test.two = false;
        test.selectone = null;
        test.selecttwo = null;
        test.combine = true;
        text.text = "Please choose two Items";
    }
    public void Inspect() {
        test.inspect = true;
        test.combine = false;
        text.text = "Please select an Item";  
    }
}

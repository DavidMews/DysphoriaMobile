using UnityEngine.UI;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Text text;
    public Transform InventorySlots;
    public GameObject InventoryPanel;
    public GameObject buttons;
    private Test test;

    Inventory inventory;
    InventorySlot[] slots;
    private DialogManager dialogManager;


    void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        test = FindObjectOfType<Test>();
        dialogManager.inDialog = false;
    }


    public void OpenInventory()
    {
        InventoryPanel.SetActive(!InventoryPanel.activeSelf);
        text.text = "";
        test.inspect = false;
        test.one = false;
        test.two = false;
        test.selectone = null;
        test.selecttwo = null;

        if (InventoryPanel.activeSelf)
        {
            dialogManager.inDialog = true;
            if(buttons != null)
            {
                buttons.SetActive(false);
            }
            
        }
        else
        {
            dialogManager.inDialog = false;

            if(buttons != null)
            {
                buttons.SetActive(true);
            }
            
        }
        
    }

   
    public void UpdateUI()
    {
        slots = InventorySlots.GetComponentsInChildren<InventorySlot>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        Debug.Log("Updating UI");
    }
}


using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "New Item",menuName ="Inventory/Item")]
public class ItemBlueprint : ScriptableObject, IPointerClickHandler
{
    new public string name = "New Item";
    public Sprite icon = null;
    public int quantity;
    public bool Collectible;
    [TextArea(3,10)]
    public string itemDescription;
    [TextArea(3, 10)]
    public string itemDescription2;

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public virtual void Use()
    {
        //use item
        //stuff happens




        Debug.Log("Using:"+name);
        Debug.Log("Info: " + itemDescription);

    }
}

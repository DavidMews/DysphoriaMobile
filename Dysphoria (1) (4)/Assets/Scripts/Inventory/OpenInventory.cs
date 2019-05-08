using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Open();
        Close();
    }
    public void Open()

    {
        if (Input.GetKey(KeyCode.Space))
        {
            inventory.SetActive(true);
        }
    }
    public void Close()

    {
        if (Input.GetKey(KeyCode.Escape))
        {
            inventory.SetActive(false);
            }
    }
}

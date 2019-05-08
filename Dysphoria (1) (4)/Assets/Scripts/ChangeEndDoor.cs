using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeEndDoor : MonoBehaviour
{

    private DemonMode demonMode;

    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite normalDoor;
    [SerializeField] Sprite demonDoor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        demonMode = FindObjectOfType<DemonMode>();
    }

    private void Update()
    {
        if (demonMode.inDemonMode == true)
        {
            spriteRenderer.sprite = demonDoor;
        }
        else
        {
            spriteRenderer.sprite = normalDoor;
        }
    }

    public void LoadWohnzimmer()
    {
        PlayerPrefs.SetString("thisScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Wohnzimmer");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cat : MonoBehaviour
{

    [SerializeField] AudioClip[] catSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        int random = Random.Range(0, catSound.Length);

        audioSource.clip = catSound[random];
        audioSource.Play();

    }

}

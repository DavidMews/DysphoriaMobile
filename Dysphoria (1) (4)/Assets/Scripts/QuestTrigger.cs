using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public Dialog[] dialog;
    private AudioSource audioSource;
    private DialogManager dialogManager;
    [SerializeField] GameObject door;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        dialogManager = FindObjectOfType<DialogManager>();
    }

    public void Start()
    {
        door.SetActive(false);
        dialogManager.StartDialog(dialog[0]);
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnMouseDown()
    {

        if (PlayerPrefs.GetInt("HasTalkedToMom") != 1)
        {
            dialogManager.StartDialog(dialog[1]);
            return;
        }

        if (door.activeInHierarchy == false)
        {
            dialogManager.StartDialog(dialog[0]);
        }


    }

    public void ActivateDoor()
    {
        door.SetActive(true);
        Destroy(gameObject);
    }
}

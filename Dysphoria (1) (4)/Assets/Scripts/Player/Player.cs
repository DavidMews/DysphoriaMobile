using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] float moveSpeed = 0.08f;
    [SerializeField] float YRestriction = 0;
    [SerializeField] float XLeftRestriction = 0;
    [SerializeField] float XRightRestriction = 0;
    public bool isWalking;
    public bool hasClothes;
    public bool isGrabbing;

    [Header("Sprites")]
    [SerializeField] Sprite normalSprite;
    [SerializeField] Sprite demonSprite;


    DialogManager dialogManager;
    DemonMode demonMode;
    private SpriteRenderer image;
    private AudioSource audioSource;
    private Vector3 targetPosition;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<SpriteRenderer>();
        dialogManager = FindObjectOfType<DialogManager>();
        demonMode = FindObjectOfType<DemonMode>();
    }

    // damit sich der Spieler beim Start nicht bewegt
    private void Start()
    {
        if (PlayerPrefs.GetInt("HasClothes") != 1)
        {
            hasClothes = false;
        }
        else
        {
            hasClothes = true;
        }

        targetPosition = transform.position;  
    }

    void Update()
    {
       
        // Spieler nicht während Dialog bewegen
        if (dialogManager.inDialog == false)
        {
            // beim Klicken -> Get Mouseposition
            if (Input.GetMouseButtonDown(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                audioSource.Play();
            }
     
            // nur unterhalb des Inventars/demonIcon
            if (targetPosition.y <= 3)
            {
                // Spieler zur Maus bewegen
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, 0.1f * moveSpeed * Time.deltaTime);
                isWalking = true;

                // sprite flippen wenn nach rechts läuft
                if (targetPosition.x > transform.position.x)
                {
                    transform.localScale = new Vector3(-1, 1, transform.localScale.z);
                    //image.flipX = true;
                }
                else if (targetPosition.x < transform.position.x)
                {
                    transform.localScale = new Vector3(1, 1, transform.localScale.z);
                    //image.flipX = false;
                }
                else
                {
                    audioSource.Stop();
                    isWalking = false;
                }
            }
            else
            {
                audioSource.Stop();
                isWalking = false;
            }    
        }
        else
        {
            audioSource.Stop();
            isWalking = false;
        }
        Begrenzungen();
    }

    private void Begrenzungen()
    {
        // Begrenzung nach oben
        if (transform.position.y >= YRestriction)
        {
            targetPosition = new Vector3(transform.position.x, YRestriction, transform.position.z);
        }

        // Begrenzung nach links
        if (transform.position.x <= XLeftRestriction)
        {
            targetPosition = new Vector3(XLeftRestriction, transform.position.y, transform.position.z);
        }

        // Begrenzung nach rechts
        if (transform.position.x >= XRightRestriction)
        {
            targetPosition = new Vector3(XRightRestriction, transform.position.y, transform.position.z);
        }
    }

    // sichtbare Begrenzung im Editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(-50, YRestriction, 0), new Vector3(50, YRestriction, 0));
        Gizmos.DrawLine(new Vector3(XLeftRestriction, -50, 0), new Vector3(XLeftRestriction, 50, 0));
        Gizmos.DrawLine(new Vector3(XRightRestriction, -50, 0), new Vector3(XRightRestriction, 50, 0));
    }
}

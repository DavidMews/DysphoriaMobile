using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DemonMode : MonoBehaviour
{
    [HideInInspector]
    public bool inDemonMode;
    private Image image;
    private MusicLoopKitchen musicLoopKitchen;
    private Player player;

    private float currentHealth;

    [SerializeField] AudioClip enterDemon;
    [SerializeField] AudioClip exitDemon;
    private AudioSource audioSource;

    [SerializeField] GameObject flash;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        player = FindObjectOfType<Player>();
    }

    private void Start()
    {
        musicLoopKitchen = FindObjectOfType<MusicLoopKitchen>();
        image = GetComponent<Image>();
        inDemonMode = false;
        currentHealth = PlayerPrefs.GetFloat("CurrentHealth", 0);
        image.fillAmount = currentHealth / 100;
    }


    private void Update()
    {
        if (inDemonMode && SceneManager.GetActiveScene().name != "EndDoor")
        {
            LoseHealth();
           
            if (currentHealth >= 100)
            {
                Death();
            }
        }

        else if (!inDemonMode && SceneManager.GetActiveScene().name != "EndDoor")
        {
            GainHealth();
        }

        image.fillAmount = currentHealth / 100;
    }

    public void ActivateDemonMode()
    {
        if (inDemonMode == true)
        {
            if (musicLoopKitchen != null)
            {
                musicLoopKitchen.PlayNormalMusic();
            }

            audioSource.clip = exitDemon;
            audioSource.Play();
            flash.SetActive(false);
            flash.SetActive(true);
            inDemonMode = false;
        }
        else
        {
            if (musicLoopKitchen != null)
            {
                musicLoopKitchen.PlayDemonMusic();
            }

            audioSource.clip = enterDemon;
            audioSource.Play();
            flash.SetActive(false);
            flash.SetActive(true);
            inDemonMode = true;
        }
    }


    private void LoseHealth()
    {
        currentHealth += Time.deltaTime;
        PlayerPrefs.SetFloat("CurrentHealth", currentHealth);
    }

    private void GainHealth()
    {
        currentHealth -= Time.deltaTime / 3;
        PlayerPrefs.SetFloat("CurrentHealth", currentHealth);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }


    private void Death()
    {
        //Erklärung das man bewusst los wurde ?!
        PlayerPrefs.SetFloat("CurrentHealth", 0);
        PlayerPrefs.SetInt("Bewusstlos", 1);
        SceneManager.LoadScene("Kinderzimmer");
    }
}

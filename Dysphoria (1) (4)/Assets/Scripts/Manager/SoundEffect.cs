using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject soundEffects;

    [Header("Thunder")]
    private float thunderTimer = 12f;
    [SerializeField] float timeBetweenThunder;
    [SerializeField] AudioClip thunder1;
    [SerializeField] AudioClip thunder2;

    private void Awake()
    {
        soundEffects = GameObject.Find("SoundEffectManager");
        if (soundEffects == null)
        {
            soundEffects = this.gameObject;
            soundEffects.name = "SoundEffectManager";
            DontDestroyOnLoad(soundEffects);
        }
        else
        {
            if (this.gameObject.name != "SoundEffectManager")
            {
                Destroy(this.gameObject);
            }
        }

        audioSource = GetComponent<AudioSource>();   
    }

    private void Start()
    {
        thunderTimer = 5f;
    }

    void Update()
    {
        ThunderSound();
    }

    void ThunderSound()
    {
        thunderTimer -= Time.deltaTime;
        if (thunderTimer <= 0)
        {
            int rand = Random.Range(0, 2);

            if (rand == 0)
            {
                audioSource.clip = thunder1;
            }
            else
            {
                audioSource.clip = thunder2;
            }

            audioSource.Play();
            thunderTimer = timeBetweenThunder;
        }
    }
}

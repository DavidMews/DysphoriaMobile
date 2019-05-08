using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopKitchen : MonoBehaviour
{

    [SerializeField] AudioClip singing;
    [SerializeField] AudioClip demonSinging;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

   
    public void PlayNormalMusic()
    {
        audioSource.clip = singing;
        audioSource.Play();
    }

    public void PlayDemonMusic()
    {
        audioSource.clip = demonSinging;
        audioSource.Play();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//using Steamworks;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    #region Attributes

    // All Audio Clips that can be used as music tracks.
    public List<AudioClip> musicClips = new List<AudioClip>();

    private AudioSource musicSource;


    private AudioSource musicPlayerAudio;


    AudioClip currentTrack;

    private float length;

    private Coroutine musicLoop;

    private MusicQueue musicQueue;


    public AudioMixer audioMixer;
    private float volume;
    public GameObject musicPlayer;
    //public AudioMixer MyaudioMixer;

    private float timeSpent;
    // private float timeSpentSum;


    #endregion

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Kueche")
        {
            musicPlayerAudio.volume = 0.05f;
        }
        else
        {
            musicPlayerAudio.volume = 0.2f;
        }
        
        
    }

    void Awake()
    {
        timeSpent = PlayerPrefs.GetFloat("TimeSpent");
        Debug.Log("Zeit insgesamt bei Start " + timeSpent);

       // timeSpentSum = PlayerPrefs.GetFloat("TimeSpent");
       // Debug.Log("Zeit: " + timeSpent);
       // Debug.Log("Zeit gesamt " + timeSpentSum);

        //When the scene loads it checks if there is an object called "MUSIC".
        musicPlayer = GameObject.Find("Music");
        if (musicPlayer == null)
        {
            //If this object does not exist then it does the following:
            //1. Sets the object this script is attached to as the music player
            musicPlayer = this.gameObject;
            //2. Renames THIS object to "MUSIC" for next time
            musicPlayer.name = "Music";
            //3. Tells THIS object not to die when changing scenes.
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            if (this.gameObject.name != "Music")
            {
                //If there WAS an object in the scene called "MUSIC" (because we have come back to
                //the scene where the music was started) then it just tells this object to 
                //destroy itself if this is not the original
                Destroy(this.gameObject);
            }
        }
    }


    #region Monobehaviour API

    void Start () {
        //AudioListener.volume = PlayerPrefs.GetFloat("MasterVolume");
        //if (!PlayerPrefs.HasKey("MasterVolume")){AudioListener.volume = 0.3f;}

        //volume = PlayerPrefs.GetFloat("MusicVolume");
        //if (!PlayerPrefs.HasKey("MusicVolume")){volume = 0.3f; }

        musicPlayerAudio = GameObject.Find("Music").GetComponent<AudioSource>();
        musicPlayerAudio.volume = volume;
        // audioMixer.SetFloat("MusicVolume", volume);
        musicQueue = new MusicQueue(musicClips);
        musicSource = GetComponent<AudioSource>();
        StartMusic();
	}

    #endregion
    
   

    public void PlayMusicCLip(AudioClip music)
    {
        musicSource.Stop();
        musicSource.clip = music;
        musicSource.Play();
    }


    public void StopMusic()
    {
        if (musicLoop != null)
            StopCoroutine(musicLoop);
    }


    public void StartMusic()
    {
        musicLoop = StartCoroutine(musicQueue.LoopMusic(this, 0, PlayMusicCLip));
    }


}


public class MusicQueue
{

    private List<AudioClip> clips;

    public MusicQueue(List<AudioClip> clips)
    {
        this.clips = clips;
    }

    public IEnumerator LoopMusic(MonoBehaviour player, float delay, System.Action<AudioClip> playFunction)
    {
        while (true)
        {
            yield return player.StartCoroutine(Run(RandomizeList(clips), delay, playFunction));
        }
    }

    public IEnumerator Run (List<AudioClip> tracks, float delay,
        System.Action<AudioClip> playFunction)
    {

        foreach (AudioClip clip in tracks)
        {
            playFunction(clip);

            yield return new WaitForSeconds(clip.length + delay);
        }

    }

    public List<AudioClip> RandomizeList(List<AudioClip> list)
    {

        List<AudioClip> copy = new List<AudioClip>(list);

        int n = copy.Count;

        while (n > 1)
        {
            n--;

            int k = Random.Range(0, n + 1);

            AudioClip value = copy[k];

            copy[k] = copy[n];
            copy[n] = value;

        }

        return copy;

    }

}


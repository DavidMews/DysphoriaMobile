using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    private string activeScene;
    private string lastScene;

    public Transform[] spawnPoint;


    private void Awake()
    {
        lastScene = PlayerPrefs.GetString("thisScene");
        activeScene = SceneManager.GetActiveScene().name;

        if (lastScene == "Kinderzimmer" && activeScene == "Flur")
        {
            transform.position = spawnPoint[0].position;
        }

        if (lastScene == "Dachboden" && activeScene == "Flur")
        {
            transform.position = spawnPoint[1].position;
        }

        if (lastScene == "Wohnzimmer" && activeScene == "Flur")
        {
            transform.position = spawnPoint[1].position;
        }

        if (lastScene == "Flur" && activeScene == "Wohnzimmer")
        {
            transform.position = spawnPoint[0].position;
        }

        if (lastScene == "EndDoor" && activeScene == "Wohnzimmer")
        {
            transform.position = spawnPoint[0].position;
        }

        if (lastScene == "Kueche" && activeScene == "Wohnzimmer")
        {
            transform.position = spawnPoint[1].position;
        }
    }


}

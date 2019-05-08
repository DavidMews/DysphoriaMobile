using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    [SerializeField] GameObject nextCutscene;

    public void NextCutscene()
    {
        nextCutscene.SetActive(true);
        this.gameObject.SetActive(false);
    }


    public void StartNewLevel()
    {
        PlayerPrefs.SetInt("HasTalkedToMom", 0);
        PlayerPrefs.SetInt("HasClothes", 0);
        PlayerPrefs.SetInt("Batterie", 0);
        PlayerPrefs.SetInt("Besen", 0);
        PlayerPrefs.SetInt("Reifen", 0);
        PlayerPrefs.SetInt("ActionFigure", 0);
        PlayerPrefs.SetInt("Kleiderbugel", 0);
        PlayerPrefs.SetInt("Feuerauto", 0);


        PlayerPrefs.SetInt("DontShowAfterMomDialog", 0);
        PlayerPrefs.SetInt("StartAfterMomDialog", 0);
        PlayerPrefs.SetInt("QuestDia", 0);

        PlayerPrefs.SetInt("Schwert", 0);
        PlayerPrefs.SetInt("Cookie", 0);
        PlayerPrefs.SetInt("Gem", 0);
        PlayerPrefs.SetInt("GimmeBoi", 0);
        PlayerPrefs.SetInt("Key", 0);
        PlayerPrefs.SetInt("Teddy", 0);


        PlayerPrefs.SetInt("FeuerautoComplete", 0);
        PlayerPrefs.SetInt("SchwertComplete", 0);
        PlayerPrefs.SetInt("GimmeBoiComplete", 0);
        PlayerPrefs.SetInt("BesenComplete", 0);

        PlayerPrefs.SetInt("SchwertInDoor", 0);
        PlayerPrefs.SetInt("TeddyInDoor", 0);
        PlayerPrefs.SetInt("ActionInDoor", 0);
        PlayerPrefs.SetInt("GimmeBoiInDoor", 0);
        PlayerPrefs.SetInt("FeuerInDoor", 0);

        PlayerPrefs.SetInt("DachbodenOpen", 0);
        PlayerPrefs.SetInt("CageUnlocked", 0);
        
        PlayerPrefs.SetInt("Bewusstlos", 0);
        PlayerPrefs.SetFloat("CurrentHealth", 0);
        SceneManager.LoadScene("Kinderzimmer");
    }
}

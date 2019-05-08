using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUGSCRIPT : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.SetInt("HasTalkedToMom", 0);
            PlayerPrefs.SetInt("HasClothes", 0);
            PlayerPrefs.SetInt("Batterie", 0);
            PlayerPrefs.SetInt("Besen", 0);
            PlayerPrefs.SetInt("Reifen", 0);
            PlayerPrefs.SetInt("ActionFigure", 0);
            PlayerPrefs.SetInt("Kleiderbugel", 0);
            PlayerPrefs.SetInt("Feuerauto", 0);
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

            PlayerPrefs.SetInt("DachbodenOpen", 0);

            PlayerPrefs.SetInt("SchwertInDoor", 0);
            PlayerPrefs.SetInt("TeddyInDoor", 0);
            PlayerPrefs.SetInt("ActionInDoor", 0);
            PlayerPrefs.SetInt("GimmeBoiInDoor", 0);
            PlayerPrefs.SetInt("FeuerInDoor", 0);


            PlayerPrefs.SetInt("CageUnlocked", 0);
            PlayerPrefs.SetInt("DontShowAfterMomDialog", 0);
            PlayerPrefs.SetInt("StartAfterMomDialog", 0);
            PlayerPrefs.SetInt("QuestDia", 0);

            Debug.Log("ALLE PLAYERPREFS = 0");

        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerPrefs.SetInt("HasTalkedToMom", 1);
            PlayerPrefs.SetInt("HasClothes", 1);
            PlayerPrefs.SetInt("Batterie", 1);
            PlayerPrefs.SetInt("Besen", 1);
            PlayerPrefs.SetInt("Reifen", 1);
            PlayerPrefs.SetInt("ActionFigure", 1);
            PlayerPrefs.SetInt("Kleiderbugel", 1);
            PlayerPrefs.SetInt("Feuerauto", 1);
            PlayerPrefs.SetInt("Schwert", 1);
            PlayerPrefs.SetInt("Cookie", 1);
            PlayerPrefs.SetInt("Gem", 1);
            PlayerPrefs.SetInt("GimmeBoi", 1);
            PlayerPrefs.SetInt("Key", 1);
            PlayerPrefs.SetInt("Teddy", 1);

           // PlayerPrefs.SetInt("FeuerautoComplete", 1);
           // PlayerPrefs.SetInt("SchwertComplete", 1);
           // PlayerPrefs.SetInt("GimmeBoiComplete", 1);
           // PlayerPrefs.SetInt("BesenComplete", 1);

            PlayerPrefs.SetInt("DachbodenOpen", 1);

            PlayerPrefs.SetInt("DontShowAfterMomDialog", 1);
            PlayerPrefs.SetInt("StartAfterMomDialog", 1);
            PlayerPrefs.SetInt("CageUnlocked", 1);
            
            Debug.Log("ALLE PLAYERPREFS = 1");

        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("HasTalkedToMom", 1);
            PlayerPrefs.SetInt("HasClothes", 1);
            Debug.Log("Mit Mom geredet + klamotten");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("Key", 1);
            Debug.Log("Schlüssel");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.SetInt("Cookie", 1);
            Debug.Log("Cookie");
        }


        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerPrefs.SetInt("GimmeBoi", 1);
            Debug.Log("GimmeBoi");
        }
    }
}

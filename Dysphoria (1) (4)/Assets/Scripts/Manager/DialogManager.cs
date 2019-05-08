using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public Image portrait;

    public GameObject dialogPanel;
    public Animator animator;
    public bool inDialog;

    [HideInInspector]
    public bool readyForAnswer;

    private Queue<string> sentences;

    void Awake()
    {
        dialogPanel.SetActive(false);
        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialog(Dialog dialog)
    {
        inDialog = true;
        dialogPanel.SetActive(true);
        animator.SetBool("IsOpen", true);
        Debug.Log("Dialog gestartet");

        portrait.sprite = dialog.portrait;

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            if (readyForAnswer)
            {
                readyForAnswer = false;
            }
            else
            {
                readyForAnswer = true;
            }       
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }


    public void EndDialog()
    {
        animator.SetBool("IsOpen", false);
        inDialog = false;
        if (PlayerPrefs.GetInt("HasTalkedToMom") == 1)
        {
            PlayerPrefs.SetInt("StartAfterMomDialog", 1);
        }

        if (PlayerPrefs.GetInt("DontShowAfterMomDialog") == 1)
        {
            PlayerPrefs.SetInt("QuestDia", 1);
            PlayerPrefs.SetInt("DontShowAfterMomDialog", 2);
        }
        else if (PlayerPrefs.GetInt("QuestDia") == 1)
        {
            PlayerPrefs.SetInt("QuestDia", 2);
        }
        else if (PlayerPrefs.GetInt("QuestDia") == 2)
        {
            PlayerPrefs.SetInt("QuestDia", 3);
        }
        else if (PlayerPrefs.GetInt("QuestDia") == 3)
        {
            PlayerPrefs.SetInt("QuestDia", 4);
        }

        PlayerPrefs.SetInt("EndDialog", 0);
    }
}

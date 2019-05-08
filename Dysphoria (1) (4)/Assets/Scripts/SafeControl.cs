using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeControl : MonoBehaviour
{
    public GameObject backButton;
    public GameObject buttongrid;
    public GameObject gemButton;
    public Text text;
    private string first;
    private string second;
    private string third;
    private string fourth;
    private string combination;
    private string correctCombination="8361";
    private PictureButton pic;
    

    // Start is called before the first frame update
    void Start()
    {
        pic = FindObjectOfType<PictureButton>();
    }
    private void OnEnable()
    {
        backButton.SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        if (first!=null&&second!=null&&third!=null&&fourth!=null)
        {
            combination = first + second + third + fourth;
            
            if (combination==correctCombination)
            {
                pic.picture.sprite = pic.safe3;
                buttongrid.SetActive(false);
                backButton.SetActive(false);
                gemButton.SetActive(true);
                text.text = "";

            }
            else
            {
                text.text = "Error";
                first = null;
                second = null;
                third = null;
                fourth = null;
            }

        }



    }

    public void ReturnOne()
    {
        if (first==null)
        {
            first = "1";
            text.text = first+" ";
            Debug.Log("first"+first);
            return;
        }
        else if (second == null)
        {
            second = "1";
            text.text = first + " " + second + " ";
            Debug.Log("second"+second);
            return;
        }
        else if (third == null)
        {
            third = "1";
            text.text = first + " " + second + " " + third + " ";
            Debug.Log("third"+third);
            return;
        }
        else if (fourth == null)
        {
            fourth = "1";
            text.text = first + " " + second + " " + third + " "+fourth;
            Debug.Log("fourth"+fourth);
            return;
        }
    }
    public void ReturnTwo()
    {
        if (first == null)
        {
            first = "2";
            text.text = first +" ";
            return;
        }
        else if (second == null)
        {
            second = "2";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "2";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "2";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnThree()
    {
        if (first == null)
        {
            first = "3";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "3";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "3";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "3";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnFour()
    {
        if (first == null)
        {
            first = "4";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "4";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "4";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "4";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnFive()
    {
        if (first == null)
        {
            first = "5";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "5"; 
            text.text = first + " "+second+" ";
            return;
        }
        else if (third == null)
        {
            third = "5";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "5";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnSix()
    {
        if (first == null)
        {
            first = "6";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "6";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "6";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "6";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnSeven()
    {
        if (first == null)
        {
            first = "7";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "7";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "7";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "7";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnEight()
    {
        if (first == null)
        {
            first = "8";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "8";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "8";
            text.text = first + " " + second + " " + third + " ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "8";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }
    public void ReturnNine()
    {
        if (first == null)
        {
            first = "9";
            text.text = first + " ";
            return;
        }
        else if (second == null)
        {
            second = "9";
            text.text = first + " " + second + " ";
            return;
        }
        else if (third == null)
        {
            third = "9";
            text.text = first + " " + second + " "+third+" ";
            return;
        }
        else if (fourth == null)
        {
            fourth = "9";
            text.text = first + " " + second + " " + third + " " + fourth;
            return;
        }
    }

}

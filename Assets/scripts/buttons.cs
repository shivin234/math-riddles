using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class buttons : MonoBehaviour
{
    public Text inputfield;
    public Text inputfield1;
     int answer = 280;
    public GameObject panel;

    public void ButtonPressed()
    {

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;

        
        
        if (buttonValue == "clear")
        {
            inputfield.text = "";
        }
        else if (buttonValue == "submit")
        {
            
            if (Convert.ToInt32(inputfield.text) == answer)
            {
                inputfield1.text = "Correct";
                SceneManager.LoadScene(2);
            }
            else
            {
                inputfield1.text = "InCorrect";
            }
            inputfield.text = "";
        }
        else if (inputfield.text == "")
        {
            inputfield.text = buttonValue;

        }
        else
        {
            inputfield.text += buttonValue;
        }
     
    }
    public void hide()
    {
        panel.gameObject.SetActive(false);
       
    }
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Delete : MonoBehaviour
{
    public TMP_InputField inputText;

    string tutorialText;

    void Start()
    {
      
    }

    public void DeleteThis()
    {
        tutorialText = inputText.text;
        inputText.Select();
        inputText.text = "";
        //PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
   }
    

 

    
}

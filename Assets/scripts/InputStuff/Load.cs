using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Load : MonoBehaviour
{
    public TMP_InputField inputText;

    string tutorialText;

    void Start()
    {
        
    }

    public void LoadThis()
    {
        tutorialText = inputText.text;
        //PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
        string userID = inputText.text.ToString();
    }
}

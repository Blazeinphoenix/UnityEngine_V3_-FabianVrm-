using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Save : MonoBehaviour
{
    public TMP_InputField inputText;
    
    string tutorialText;

    void Start()
    {
        tutorialText = PlayerPrefs.GetString("tutorialTextKeyName");
        inputText.text = tutorialText;
    }

    public void SaveThis()
    {
        tutorialText = inputText.text;
        PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
    }
}

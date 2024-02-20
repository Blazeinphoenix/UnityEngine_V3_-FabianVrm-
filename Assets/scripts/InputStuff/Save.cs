using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Save : MonoBehaviour
{
    public TMP_InputField inputText;
    
    private string tutorialText;

  

    public void SaveThis()
    {
        tutorialText = inputText.text;
        PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
    }

    public void LoadThis()
    {

        inputText.text = PlayerPrefs.GetString("tutorialTextKeyName", "");

    }

    public void DeleteThis()
    {
        PlayerPrefs.DeleteAll();
        inputText.text = "";

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handler : MonoBehaviour
{
    public string buttonInput = string.Empty;
    public Button button; 

    private void Awake(){
        button.onClick.AddListener(SubmitLetter);
    }

    private string SubmitLetter(){
        
        return buttonInput;
    }
}

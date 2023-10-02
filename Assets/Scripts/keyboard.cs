using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    string word = null;

    public void alphabetFunction(string alphabet){
        word = alphabet;
        Debug.Log("Clicked "+word);
    }

    public string SetWord(){
        return word;
    }
}

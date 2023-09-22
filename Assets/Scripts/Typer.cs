using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text wordOutput = null;

    private string remainingWord = string.Empty;
    private string currentWord = "ada is funny";

    private void SetCurrentWord(){
        //the word will get the words from the word bank
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newRemainingWord){
        remainingWord = newRemainingWord;
        wordOutput.text = remainingWord;
    }

    void Start()
    {
        SetCurrentWord();
    }

    void Update()
    {
        CheckInput();
    }

    private void CheckInput(){
        if(Input.anyKeyDown){
            string inputtedWord = Input.inputString;

            if(inputtedWord.Length == 1){           // takes in only one key input at a time
                EnterLetter(inputtedWord);
            }
        }
    }

    private void EnterLetter(string typedLetter){
        if(IsLetterCorrect(typedLetter)){
            RemoveLetter();
            if(IsWordFinished()){
                SetCurrentWord();
            }
        }
    }
    
    bool IsLetterCorrect(string enteredLetter){
        return remainingWord.IndexOf(enteredLetter) == 0;
    }

    private void RemoveLetter(){        //removes the letter if it is correct input
        string subtractedWord = remainingWord.Remove(0, 1);   // Removes the first character of the string
        SetRemainingWord(subtractedWord);
    }

    private bool IsWordFinished(){
        return remainingWord.Length ==0;
    }

}

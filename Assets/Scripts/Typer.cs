using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text wordOutput = null;                      // the word that is dispalyed in the game

    private string remainingWord = string.Empty;        // the remainder of the word while we are typing.
    private string currentWord = "hello world";        // the word we are trying to complete

    private void SetCurrentWord(){
        //the word will get the words from the word bank
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newRemainingWord){         //setting up the remainder of the words
        remainingWord = newRemainingWord;                           //
        wordOutput.text = remainingWord;                            //setting the remainingWord into wordOutput where it will be displayed on user screen.
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
            EnterLetter(inputtedWord); 
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
        return remainingWord.IndexOf(enteredLetter) == 0;       //checks if the entered inputs value is the index of 0 , which means that is it the first letter
    }

    private void RemoveLetter(){        //removes the letter if it is correct input
        string subtractedWord = remainingWord.Remove(0, 1);   // Removes the first character of the string
        SetRemainingWord(subtractedWord);
    }

    private bool IsWordFinished(){
        return remainingWord.Length == 0;
    }

}

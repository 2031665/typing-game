using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Text wordOutput = null;                      // the word that is dispalyed in the game
    public Bank wordBank = null;
    private string remainingWord = string.Empty;        // the remainder of the word while we are typing.
    private string currentWord = string.Empty;        // the word we are trying to complete only in the begining (the word here will be gathered by the word bank)

    private void SetCurrentWord(){
        currentWord = wordBank.GetWord();
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
        CheckInput();                                                // constantly being checked for imputs 
    }

    private void CheckInput(){
        if(Input.anyKeyDown){
            string inputtedWord = Input.inputString;
            if(inputtedWord == remainingWord.Substring(0,1)){
                RemoveLetter();
                if(remainingWord.Length == 0){
                    SetCurrentWord();
                }
            }
        }
    }
    
    private void RemoveLetter(){                                    //removes the letter if it is correct input
        string remainingWordRemoved = remainingWord.Remove(0, 1);         // Removes the first character of the string
        SetRemainingWord(remainingWordRemoved);                           // updates the subtracted new word as the remainingWord
    }
}

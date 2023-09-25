using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Bank : MonoBehaviour
{
    private List<string> wordBankFileWords = File.ReadAllLines("WordBank.txt").ToList();

    private void Awake(){
        Randomize(wordBankFileWords);
    }

    private void Randomize(List<string> list){                              // shuffling the words, so that they are all randomized every game.
        for(int i = list.Count-1; i > 0; i--){                              // this is the fisher-yates shuffle.
            string temp = list[i];
            int rand = Random.Range(0, i+1);
            list[i] = list[rand];
            list[rand] = temp;
        }
    }

    public string GetWord(){
        string newWord = string.Empty;

        if(wordBankFileWords.Count != 0){
            newWord = wordBankFileWords.Last();                 // gettint the last word from the list wordBankFileWords
            wordBankFileWords.Remove(newWord);
        }

        return newWord;
    }
}

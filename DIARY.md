This is the initial diart of typing-game

22/09/2023
i have created the initial project by taking the first main step of the typing game. the idea i have for the typing game is that i will have one main controller where all the game actions will be happening while on another file there will be a word bank where the words are randomly given to the user. so far i have finished the main controller Typer.cs as it was said this file includes the basic functions of how the game will work.

The word that the user is asked to type is displayed on the screen, as the letters of the displayed word is typed the typed, the displayed word will update by removing the typed word, this process will repeat over till the user completes the displayed word. However if user inputs incorrect letter there will be no update on the displayed word.

The global variables are the main part for updating and displaying the word that needs to be typed. remainingWord is the variable for getting the updated word to set the Text UI variable. wordOutput is the Text UI variable to display the word in users screen. currentWord variable is used only when starting to a new word, to set up the initial word. (AT THIS MOMENT THIS WORD IS HARDCODED BUT IN THE FUTURE IT WILL BE CONNECTED TO A WORDBANK)
![Alt text](image-5.png)

The method SetCurrentWord() will start the process by setting up the initial word by using the currentWord global variable as an argument of another method called SetRemainingWord(). ![Alt text](image-6.png) this SetRemainingWord() method is updating the the remainingWord with the newRemainingWord that is provided by the argument, update the wordOutput global variable for display.![Alt text](image-7.png). However as it was said above, for update action to occur the user needs to input the correct key, this is where the CheckInput() method comes in. CheckInput() gets the any inputted key and checks if it matches with the remainingWord's first character (explaing with small comments on report with arrows that Substring() is used to get the first character of the remainigWord). if the characters are matching the first letter of the remainingWord will be removed by the RemoveLetter() method and there will be another check if there are still characters in remainingWord, if there is no characters left a new word will be displayed for the user using SetCurrentWord().however if the inputted key does not match the first letter in the first place none of the explained action will happen and remainingWord will stay as it was.
![Alt text](image-8.png)

the above picture shows that RemoveLetter() was used for removal of the first letter of remainingWord, this was done by using the Remove() built in method. the new version of the word remainingWordRemoved is used as an argument for SetRemainingWord(remainingWordRemoved) method to update the remainingWord.
![Alt text](image-10.png)

this whole design was put all together with the help of tthis flowchart
![Alt text](image-2.png)

here is an example:
![Alt text](image.png) after the letter H is inputted this is how it will look ![Alt text](image-1.png)
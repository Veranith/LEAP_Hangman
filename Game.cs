using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
   public class Game
    {

        public int remainingGuesses { get; set; }
        public List<char> correctGuesses { get; set; }
        public List<char> failedGuesses { get; set; }
        public string word { get; set; }
        public string userGameMessage { get; set; }

        public Game()
        {
            remainingGuesses = 6;
            word = RandomWord.next(RandomWord.dictionary);
            correctGuesses = new List<char>();
            failedGuesses = new List<char>();
            userGameMessage = "";
        }

        public void start()

        {
            do
            {
                printGameBoard();

                char chosenChar = UserIOInput.getLetterFromUser();

                if (word.Contains(chosenChar) && correctGuesses.Contains(chosenChar) == false)
                {
                    correctGuesses.Add(chosenChar);
                    if (checkIfWon())
                    {
                        Console.WriteLine("\nYou won!!!");
                        break;
                    }
                } else
                {
                    if (failedGuesses.Contains(chosenChar) == false && correctGuesses.Contains(chosenChar) == false)
                    {
                        failedGuesses.Add(chosenChar);
                        remainingGuesses--;
                    }
                    else
                    {
                        userGameMessage = ("You have already choosen this letter.");
                    }
                }
            }
            while (remainingGuesses > 0);

            if (remainingGuesses == 0)
            {
                Console.WriteLine("Game over!");
            }

        }

        private void printGameBoard()
        {
            UserIODisplay.printGameBoard(this);
        }

        private bool checkIfWon()
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (correctGuesses.Contains(word[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

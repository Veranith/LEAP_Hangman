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

        public Game()
        {
            remainingGuesses = 6;
            word = RandomWord.next(RandomWord.dictionary);
            correctGuesses = new List<char>();
            failedGuesses = new List<char>();
        }

        public void start()

        {
            //Game game = new();
            
            UserIODisplay.welcomeMessage();

            do
            {
                printGameBoard();

                char chosenChar = UserIOInput.getLetterFromUser();

                if (word.Contains(chosenChar) && correctGuesses.Contains(chosenChar) == false)
                {
                    correctGuesses.Add(chosenChar);
                    if (checkIfWon())
                    {
                        Console.WriteLine("You won!!!");
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
                        Console.WriteLine("\nYou have already choosen this lettter.\n");
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
            UserIODisplay.printGameBoard(correctGuesses, word, remainingGuesses, failedGuesses);
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

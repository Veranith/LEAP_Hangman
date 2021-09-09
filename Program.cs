using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //requirements: welcome screen, 

            // display class
            // _ _ _ _ _ S _    Guess left: 6   Guessed letters:  f g t r 
             
            Game game = new();

            game.start();

            //UserIODisplay.welcomeMessage();
            //UserIODisplay.printGameBoard(game.correctGuesses, game.word, game.remainingGuesses, game.failedGuesses);

            //char test = UserIOInput.getLetterFromUser();
            //if (game.word.Contains(test))
            //{
            //    game.correctGuesses.Add(test);
            //}

            //Console.WriteLine(test);
            
            // game class
            //   -- array guessedLetters
            //   -- int remaingLimbs
            //   -- method didIwin()

            // user IO class - would use display class

            // Word class - 
            //   -- randomWord()
            //   -- dictionary
        }
    }
}

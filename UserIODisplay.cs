using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class UserIODisplay
    {

        public static void welcomeMessage()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Welcome to Hangperson.");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }

        public static void printGameBoard(List<char> correctLetters, string word, int remainingGuesses, List<char> failedGuesses)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (correctLetters != null)
                {
                    if (correctLetters.Contains(word[i]))
                    {
                        sb.Append(word[i] + " ");
                    }
                    else
                    {
                        sb.Append("_ ");
                    }
                }
                else
                {
                    sb.Append("_ ");
                }
                
            }

            sb.Append("\t\tGuesses left: "+ remainingGuesses);

            sb.AppendLine("\t\tGuessed letters: " + failedGuesses);

            Console.WriteLine(sb.ToString());

        }
    }
}

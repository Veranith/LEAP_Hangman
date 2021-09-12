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
                // null-conditional operator
                // https://docs.microsoft.com/en-us/archive/msdn-magazine/2014/october/csharp-the-new-and-improved-csharp-6-0
                if (correctLetters?.Contains(word[i]) ?? false)
                {
                    sb.Append(word[i] + " ");
                }
                else
                {
                    sb.Append("_ ");
                }   
            }

            sb.Append("\t\tGuesses left: "+ remainingGuesses);
            sb.Append("\t\tGuessed letters: ");
            sb.AppendJoin(" ", failedGuesses);
            sb.AppendLine();
            Console.WriteLine(sb.ToString());

        }
    }
}

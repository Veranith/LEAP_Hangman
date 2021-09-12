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
            sb.AppendLine("\n   ** Welcome to Hangperson **\n");
            sb.AppendLine("Try to find the hidden word by selecting letters one at a time before running out of guesses.");

            Console.WriteLine(sb.ToString());
        }

        public static void printGameBoard(Game game)
        {
            Console.Clear();
            welcomeMessage();
            var sb = new StringBuilder();

            if (game.userGameMessage.Length > 0)
            {
                sb.AppendLine();
                sb.AppendLine(game.userGameMessage);
                sb.AppendLine();
                game.userGameMessage = "";
            } else { sb.AppendLine("\n\n"); }


            sb.Append('\t');
            for (int i = 0; i < game.word.Length; i++)
            {
                // null-conditional operator
                // https://docs.microsoft.com/en-us/archive/msdn-magazine/2014/october/csharp-the-new-and-improved-csharp-6-0
                if (game.correctGuesses?.Contains(game.word[i]) ?? false)
                {
                    sb.Append(game.word[i] + " ");
                }
                else
                {
                    sb.Append("_ ");
                }   
            }

            sb.Append("\t\tGuesses left: "+ game.remainingGuesses);
            sb.Append("\t\tMissed letters: ");
            sb.AppendJoin(" ", game.failedGuesses);
            sb.AppendLine();
            Console.WriteLine(sb.ToString());

        }
    }
}

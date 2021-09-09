using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class UserIOInput
    {
        
        public static char getLetterFromUser()
        {
            
            string result = "";

            do
            {
                Console.Write("Please type a letter : ");
                result = Console.ReadLine();
            }
            while (result.Length != 1);

            return result[0];
        }
    }
}

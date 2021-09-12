﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class RandomWord
    {
        public static List<string> dictionary = new() { "LEAP", "Cat", "Dog", "Dendrochronology", "Microsoft", "Windows", "Datacenter", "Computer" };

        public static string next(List<string> dictionary)
        {
            Random random = new();

            return dictionary[random.Next(0,dictionary.Count)].ToLower();
        }
        
    }
}

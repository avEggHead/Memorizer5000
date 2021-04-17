using StringToolkit;
using StringToolkit.Models;
using System;

namespace Memorizer5000
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type or Paste in a sentence you want to memorize. (do not exceed 254 characters)");
            string sentence = Console.ReadLine();
            Console.Clear();
            // find the middle word

            // find the number of spaces
            // loop through the char array of string stuff
            IStringUtilities stringToolkit = new StringUtilities();

            WordModel[] words = stringToolkit.GetWordModels(sentence);

            for(int i =0; i < words.Length; i++)
            {
                sentence = stringToolkit.RandomlyHideWord(sentence).Item2;
                Console.WriteLine(sentence);
                Console.WriteLine("Press a key");
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
            // divide the number of spaces by 2


        }
    }
}

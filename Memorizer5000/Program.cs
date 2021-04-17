using StringToolkit;
using System;

namespace Memorizer5000
{
    class Program
    {
        static void Main(string[] args)
        {
            // take a sentence and remove the middle word

            string sentence = "This is the first sentence to test";

            // find the middle word

            // find the number of spaces
            // loop through the char array of string stuff

            IStringUtilities stringToolkit = new StringUtilities();

            Console.WriteLine(stringToolkit.CountSpaces(sentence));
            Console.ReadKey();

            string[] words = stringToolkit.GetWords(sentence);

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();

            Console.WriteLine(stringToolkit.HideWord(sentence, 4));

            Console.ReadKey();
            // divide the number of spaces by 2


        }
    }
}

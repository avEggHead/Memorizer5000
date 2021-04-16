using System;

namespace StringToolkit
{
    public class StringUtilities : IStringUtilities
    {
        public int CountSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if (character.ToString().Contains(" "))
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }
    }
}

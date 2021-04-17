using System;

namespace StringToolkit
{
    public class StringUtilities : IStringUtilities
    {
        public int CountSpaces(string sentence)
        {
            if (sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.StringLengthError); }
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

        public int CountWords(string sentence)
        {
            int numberOfWords = 0;
            int numberOfSpaces = this.CountSpaces(sentence);
            if(!IsSpaceAtEnd(sentence) && !(IsSpaceAtStart(sentence)))
            {
                numberOfWords = numberOfSpaces + 1;
            }
            return numberOfWords;
        }

        public bool IsSpaceAtEnd(string sentence)
        {
            if (sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.StringLengthError); }
            bool isSpaceAtEnd = false;
            int length = sentence.Length;
            if(sentence[length - 1].ToString() == " ")
            {
                isSpaceAtEnd = true;
            }
            return isSpaceAtEnd;
        }

        public bool IsSpaceAtStart(string sentence)
        {
            if(sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.StringLengthError); }
            bool isSpaceAtStart = false;
            if(sentence[0].ToString() == " ")
            {
                isSpaceAtStart = true;
            }
            return isSpaceAtStart;
        }
    }
}

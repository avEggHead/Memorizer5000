using StringToolkit.Models;
using System;

namespace StringToolkit
{
    public class StringUtilities : IStringUtilities
    {
        public int CountSpaces(string sentence)
        {
            if (sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.LengthError); }
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
            } else
            {
                throw new StringUtilitiesException(MessageConstants.FormatError);
            }
            return numberOfWords;
        }

        public string[] GetWords(string sentence)
        {
            if (sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.LengthError); }
            int numberOfWords = this.CountWords(sentence);
            string[] words = new string[numberOfWords];
            words = sentence.Split(" ");
            return words;
        }

        public WordModel[] GetWordsModel(string sentence)
        {
            string[] words = this.GetWords(sentence);
            WordModel[] wordModels = new WordModel[words.Length];
            int startOfWord = 0;

            for (int i = 0; i < words.Length; i++)
            {
                WordModel word = new WordModel();
                word.Word = words[i];
                word.WordLength = words[i].Length;
                word.StartOfWordIndexInSentence = startOfWord;
                startOfWord = startOfWord + word.WordLength + 1;
                wordModels[i] = word;
            }
            return wordModels;
        }

        public string HideWord(string sentence, int wordNumberInSentence)
        {
            string result = string.Empty;
            WordModel[] words = this.GetWordsModel(sentence);
            WordModel wordToHide = words[wordNumberInSentence -1];
            result = sentence.Remove(wordToHide.StartOfWordIndexInSentence, wordToHide.WordLength);
            for(int i = 0; i < wordToHide.WordLength; i++)
            {
                result = result.Insert(wordToHide.StartOfWordIndexInSentence, "_");
            }

            return result;
        }

        public bool IsSpaceAtEnd(string sentence)
        {
            if (sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.LengthError); }
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
            if(sentence.Length == 0) { throw new StringUtilitiesException(MessageConstants.LengthError); }
            bool isSpaceAtStart = false;
            if(sentence[0].ToString() == " ")
            {
                isSpaceAtStart = true;
            }
            return isSpaceAtStart;
        }
    }
}

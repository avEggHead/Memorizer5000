using StringToolkit.Models;
using System;

namespace StringToolkit
{
    public interface IStringUtilities
    {
        public int CountSpaces(string sentence);
        public bool IsSpaceAtEnd(string sentence);
        public bool IsSpaceAtStart(string sentence);
        public int CountWords(string sentence);
        public string[] GetWords(string sentence);
        public string HideWord(string sentence, int wordNumberInSentence);
        public WordModel[] GetWordModels(string sentence);
        public Tuple<WordModel, string> RandomlyHideWord(string sentence);
    }
}
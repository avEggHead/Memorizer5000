namespace StringToolkit
{
    public interface IStringUtilities
    {
        public int CountSpaces(string sentence);
        public bool IsSpaceAtEnd(string sentence);
        public bool IsSpaceAtStart(string sentence);
        public int CountWords(string sentence);
    }
}
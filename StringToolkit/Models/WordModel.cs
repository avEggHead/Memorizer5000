using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToolkit.Models
{
    public class WordModel
    {
        public string Word { get; set; }

        public int WordLength { get; set; }

        public int StartOfWordIndexInSentence { get; set; }

        public int PositionInSentence { get; set; }

        public bool IsHidden { get; set; }
    }
}

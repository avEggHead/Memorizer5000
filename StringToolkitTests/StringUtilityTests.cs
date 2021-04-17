using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringToolkit;
using StringToolkit.Models;
using System;

namespace StringToolkitTests
{
    [TestClass]
    public class StringUtilityTests
    {
        [TestMethod]
        public void CountSpacesShouldReturnCorrectNumber()
        {
            // Arrange
            IStringUtilities utility = new StringUtilities();
            string sentence = "There are three spaces";
            int expected = 3;

            // Act
            int actual = utility.CountSpaces(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsThereASpaceAtTheEndTrue()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the end ";
            bool expected = true;

            // Act
            bool actual = stringUtilities.IsSpaceAtEnd(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsThereASpaceAtTheEndFalse()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is not a space at the end";
            bool expected = false;

            // Act
            bool actual = stringUtilities.IsSpaceAtEnd(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(StringUtilitiesException))]
        public void IsThereASpaceAtTheEndStringLengthZero()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "";

            // Act
            bool actual = stringUtilities.IsSpaceAtEnd(sentence);

            // Assert in attribute
        }

        [TestMethod]
        public void IsThereASpaceAtTheStartTrue()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = " There is a space at the start";
            bool expected = true;

            // Act
            bool actual = stringUtilities.IsSpaceAtStart(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsThereASpaceAtTheStartFalse()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the start";
            bool expected = false;

            // Act
            bool actual = stringUtilities.IsSpaceAtStart(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(StringUtilitiesException))]
        public void IsThereASpaceAtTheStartLengthZero()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "";

            // Act
            bool actual = stringUtilities.IsSpaceAtStart(sentence);

            // Assert in attribute
        }

        [TestMethod]
        [DataRow("There are four words", 4)]
        [DataRow("There are three", 3)]
        [DataRow("There are five words here", 5)]
        [DataRow("There are six words in this", 6)]
        [DataRow("Just two", 2)]
        public void CountWordsShouldReturnCorrectNumber(string sentence, int expected)
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();

            // Act
            int actual = stringUtilities.CountWords(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("There are four words")]
        public void PutIndividualWordsInArray(string sentence)
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string[] expected = new string[] { "There", "are", "four", "words" };

            // Act
            string[] actual = stringUtilities.GetWords(sentence);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
        }

        [TestMethod]
        [DataRow(" There are four words")]
        [DataRow("There are four words ")]
        [ExpectedException(typeof(StringUtilitiesException))]
        public void PutIndividualWordsInArrayThrowsException(string sentence)
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();

            // Act
            stringUtilities.GetWords(sentence);

            // Assert exception thrown in attribute
        }

        [TestMethod]
        public void HideWord()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the start";
            bool expected = false;

            // Act
            sentence = stringUtilities.HideWord(sentence, 1);
            bool actual = sentence.Contains("There");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RandomlyHideWord()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the start";

            // Act
            Tuple<WordModel, string> result = stringUtilities.RandomlyHideWord(sentence);

            // Assert
            Assert.AreEqual(sentence.Length, result.Item2.Length);
            Assert.IsTrue(sentence.Contains(result.Item1.Word));
        }

        [TestMethod]
        public void GetArrayOfComplexWordModel()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the start";

            // Act
            WordModel[] sentenceModel = stringUtilities.GetWordModels(sentence);

            // Assert
            Assert.IsTrue(sentenceModel.Length == 7);
        }

        [TestMethod]
        public void CheckTheWordModels()
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();
            string sentence = "There is a space at the start";

            // Act
            WordModel[] sentenceModel = stringUtilities.GetWordModels(sentence);

            // Assert
            Assert.IsTrue(sentenceModel[0].WordLength == 5);
            Assert.IsTrue(sentenceModel[1].WordLength == 2);
            Assert.IsTrue(sentenceModel[2].WordLength == 1);
            Assert.IsTrue(sentenceModel[6].WordLength == 5);
            Assert.IsTrue(sentenceModel[1].StartOfWordIndexInSentence == 6);
            Assert.IsTrue(sentenceModel[2].StartOfWordIndexInSentence == 9);
            Assert.IsTrue(sentenceModel[6].StartOfWordIndexInSentence == 24);
            Assert.IsTrue(sentenceModel[6].Word == "start");
            Assert.IsTrue(sentenceModel[5].Word == "the");
            Assert.IsTrue(sentenceModel[0].PositionInSentence == 1);
            Assert.IsTrue(sentenceModel[1].PositionInSentence == 2);
            Assert.IsTrue(sentenceModel[2].PositionInSentence == 3);

        }
    }
}

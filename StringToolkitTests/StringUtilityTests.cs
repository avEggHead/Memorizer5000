using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringToolkit;

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
        public void CountWordsShouldReturnCorrectNumber(string sentence, int expected)
        {
            // Arrange
            IStringUtilities stringUtilities = new StringUtilities();

            // Act
            int actual = stringUtilities.CountWords(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

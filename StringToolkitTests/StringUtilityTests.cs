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
            StringUtilities utility = new StringUtilities();
            string sentence = "There are three spaces";
            int expected = 3;

            // Act
            int actual = utility.CountSpaces(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

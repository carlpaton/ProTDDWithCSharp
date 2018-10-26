using NUnit.Framework;

namespace ChapterOne.UnitTests
{
    [TestFixture]
    public class UtilitiesTests
    {
        [Test]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new ChapterOneExample.Utilities.StringUtilities();
            
            var actualResult = classUnderTest.CountOccurrences(stringToCheck, stringToFind);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

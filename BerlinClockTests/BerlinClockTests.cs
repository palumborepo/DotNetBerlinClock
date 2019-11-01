using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Tests
{
    [TestClass]
    public class BerlinClockTests
    {
        [TestMethod]
        public void VerifyConversionForMidnightAt00_00()
        {
            // Arrange
            string time = "00:00:00";
            TimeConverter timeConverter = new TimeConverter();

            // Act
            string convertedTime = timeConverter.ConvertTime(time);

            // Assert
            Assert.AreEqual(ExpectedResults.MidnightAt00_00Lamps, convertedTime);
        }

        [TestMethod]
        public void VerifyConversionForMiddleAfternoon()
        {
            // Arrange
            string time = "13:17:01";
            TimeConverter timeConverter = new TimeConverter();

            // Act
            string convertedTime = timeConverter.ConvertTime(time);

            // Assert
            Assert.AreEqual(ExpectedResults.MiddelAfternoonLamps, convertedTime);
        }

        [TestMethod]
        public void VerifyConversionForJustBeforeMidnight()
        {
            // Arrange
            string time = "23:59:59";
            TimeConverter timeConverter = new TimeConverter();

            // Act
            string convertedTime = timeConverter.ConvertTime(time);

            // Assert
            Assert.AreEqual(ExpectedResults.JustBeforeMidnightLamps, convertedTime);
        }

        [TestMethod]
        public void VerifyConversionForMidnightAt24_00()
        {
            // Arrange
            string time = "24:00:00";
            TimeConverter timeConverter = new TimeConverter();

            // Act
            string convertedTime = timeConverter.ConvertTime(time);

            // Assert
            Assert.AreEqual(ExpectedResults.MidnightAt24_00Lamps, convertedTime);
        }

        [TestMethod]
        public void GivenAnInvalidTimeHour_ShouldNotPassTimeValidation()
        {
            // Arrange
            string time = "25:00:00";

            // Act
            bool isValid = TimeValidator.IsTimeValid(time);

            // Assert
            Assert.IsFalse(isValid, "TimeValidator is broken, it's not working correctly");
        }

        [TestMethod]
        public void GivenAnInvalidTimeMinute_ShouldNotPassTimeValidation()
        {
            // Arrange
            string time = "23:62:00";

            // Act
            bool isValid = TimeValidator.IsTimeValid(time);

            // Assert
            Assert.IsFalse(isValid, "TimeValidator is broken, it's not working correctly");
        }

        [TestMethod]
        public void GivenAnInvalidTimeSecond_ShouldNotPassTimeValidation()
        {
            // Arrange
            string time = "22:12:60";

            // Act
            bool isValid = TimeValidator.IsTimeValid(time);

            // Assert
            Assert.IsFalse(isValid, "TimeValidator is broken, it's not working correctly");
        }
    }
}
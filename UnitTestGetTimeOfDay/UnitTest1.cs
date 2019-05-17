using System;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGetTimeOfDay
{

    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetTimeOfDay_For6AM_ReturnsMorning()
        {
            // Arrange phase is empty: testing static method, nothing to initialize

            // Act
            string timeOfDay = Program.GetTimeOfDay(new DateTime(2015, 12, 31, 06, 00, 00));

            // Assert
            Assert.AreEqual("Morning", timeOfDay);
        }
    }
}

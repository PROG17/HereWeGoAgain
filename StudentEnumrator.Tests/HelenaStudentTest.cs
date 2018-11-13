using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumerator.Tests
{
    [TestClass]
    public class HelenaStudentTest
    {
        [TestMethod]
        public void TestHelenaSaysGoodMorning()
        {
            // Arrange
            var student = new HelenaStudent();

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

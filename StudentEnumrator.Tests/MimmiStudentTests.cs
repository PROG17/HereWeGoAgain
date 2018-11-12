using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class MimmiStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new MimmiStudent();
            var expected = "God morgon!";

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

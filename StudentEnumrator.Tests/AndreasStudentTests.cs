using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class AndreasStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new AndreasStudent();
            var expected = "Hejjeehh...";

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

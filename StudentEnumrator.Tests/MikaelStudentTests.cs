using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class MikaelStudentTests
    {

        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new MikaelStudent();

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}

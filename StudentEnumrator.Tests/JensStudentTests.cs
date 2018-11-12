using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class JensStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new JensStudent();

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

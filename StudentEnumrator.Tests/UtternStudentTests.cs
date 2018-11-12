using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class UtternStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new UtternStudent();
            var expected = @"Uttern är ett smidigt, 
långsmalt djur med korta ben, brett huvud och lång, muskulös svans. 
Pälsen är ljusbrun med en nästan vit haklapp. Den är starkt anpassad för ett liv i vatten";

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

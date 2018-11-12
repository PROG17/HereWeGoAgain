using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class JohannaStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new JohannaStudent();

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

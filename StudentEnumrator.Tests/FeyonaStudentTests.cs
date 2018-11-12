using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumrator.Tests
{
    public class FeyonaStudentTests
    {
        [TestMethod]
        public void TestSayGoodmorning()
        {
            // Arrange
            var student = new FeyonaStudent();

            // Act
            var result = student.SayGoodmorning();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

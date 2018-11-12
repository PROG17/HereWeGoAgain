using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentEnumerator;

namespace StudentEnumrator.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void NumberOfStudentsMatchExpectation()
        {
            // Arrange
            var studentRepository = new StudentRepository();
            int expectedCount = 0;

            // Act
            var result = studentRepository.GetNumberOfStudents();

            // Assert
            Assert.AreEqual(expectedCount, result, "Antalet studenter är inte det förväntade");


        }

        [TestMethod]
        public void Add_One_Student_And_Check_NumberOfStudents()
        {
            // Arrange
            var studentRepository = new StudentRepository();
            var student = new Teacher("Fredrik");
            int expectedCount = 1;

            // Act
            studentRepository.Add(student);
            var result = studentRepository.GetNumberOfStudents();

            // Assert
            Assert.AreEqual(expectedCount, result, "Antalet studenter är inte det förväntade");

        }

        [TestMethod]
        public void TestSayGoodMorning()
        {
            // Arrange
            var studentRepository = new StudentRepository();
            var person = new Teacher("Fredrik");
            int expectedCount = 1;

            // Act
            studentRepository.Add(person);
            var result = studentRepository.SayGoodMorning();

            // Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void TestRegisterStudents()
        {
            // Arrange
            var studentRepository = new StudentRepository();
            int expectedCount = 4;

            // Act
            Program.RegisterStudents(studentRepository);
            var result = studentRepository.GetNumberOfStudents();

            // Assert
            Assert.AreEqual(expectedCount, result);
        }
    }
}

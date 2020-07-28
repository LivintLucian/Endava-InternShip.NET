using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Moq;
using NUnit.Framework;
using Student_Management_System.Controllers;
using Student_Management_System.DAL;
using Student_Management_System.Models;

namespace NUnitTestProject.Tests
{
    [TestFixture]
    public class Tests
    {
        private SchoolContext schoolContext;
        static Mock<SchoolContext> mockedSchoolContext = new Mock<SchoolContext>();
        StudentController studentController = new StudentController(mockedSchoolContext.Object);
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void GiveName_WhenLengthSmallerThan64_ThenReturnStudentName()
        {
            schoolContext = new SchoolContext();

            foreach (var schoolContextStudent in schoolContext.Students)
            {
                //Given
                var firstName = schoolContextStudent.FirstName;
                var lastName = schoolContextStudent.LastName;
                string firstNameResult= null, lastNameResult= null;

                //When
                if (firstName.Length < 64 && lastName.Length < 64)
                {
                    firstNameResult = firstName;
                    lastNameResult = lastName;
                }

                //Assert
                Assert.IsNotNull(firstNameResult);
                Assert.IsNotNull(lastNameResult);
            }
        }

        [Test]
        public void GivenName_WhenIsNotNull_ThenReturnStudentName()
        {
            schoolContext = new SchoolContext();

            foreach (var schoolContextStudent in schoolContext.Students)
            {
                //Given
                var firstName = schoolContextStudent.FirstName;
                var lastName = schoolContextStudent.LastName;
                string firstNameResult = null, lastNameResult = null;

                //When
                if (firstName != null && lastName != null)
                {
                    firstNameResult = firstName;
                    lastNameResult = lastName;
                }

                //Assert
                Assert.IsNotNull(firstNameResult);
                Assert.IsNotNull(lastNameResult);
            }
        }

        [Test]
        public void GivenId_WhenIsNotNull_ThenReturnStudentId()
        {
            schoolContext = new SchoolContext();
            foreach (var schoolContextStudent in schoolContext.Students)
            {
                //Given
                var id = schoolContextStudent.Id;
                string idResult = null;

                //When
                if (id != null)
                {
                    idResult = id;
                }

                //Assert
                Assert.IsNotNull(idResult);
            }
        }

        [Test]
        public void GiveId_WhenNotExistAllReady_ThenIdIsValid()
        {
            schoolContext = new SchoolContext();

            foreach (var schoolContextStudent in schoolContext.Students)
            {
                //Given
                var id = schoolContextStudent.Id;
                string idResult = null;
                var isUnique = schoolContextStudent.Id.Distinct().Count() == schoolContextStudent.Id.Count();

                //When
                if (!isUnique)
                {
                    idResult = id;
                }

                //Assert
                Assert.IsNotNull(idResult);
            }
        }

        [Test]
        public void GiveGrade_WhenStudentNotExist_ThenReturnError()
        {
            Student student=new Student();
            
            //Given
            Mock<SchoolContext> mockedSchoolContext = new Mock<SchoolContext>();
            var result = mockedSchoolContext.Setup( x => x.Students.Count());

            //When
            StudentController studentController=new StudentController(mockedSchoolContext.Object);
            studentController.Add(student);
            var newResult = mockedSchoolContext.Setup(x => x.Students.Count());

            //Assert
            Assert.That(result, Is.LessThan(newResult));
        }

        [Test]
        public void GiveId_WhenIsValid_ThenReturn_StudentGradeAverage()
        {
            schoolContext = new SchoolContext();
            StudentController studentController = new StudentController(schoolContext);

            foreach (var student in schoolContext.Students)
            {
                //Given
                var id = student.Id;

                //When
                var result = studentController.GetStudentAverageGrade(id);

                //Then
                Assert.IsNotNull(result);
            }

        }

        [Test]
        public void GivenStudent_WhenIdNull_ThenReturnMsgError()
        {
            var student = new Student
            {
                Id = null,
                FirstName = "Livint",
                LastName = "Lucian",
                Enrollments = new List<Enrollment>()
            };

            Assert.That(() => studentController.Add(student),
                Throws.TypeOf<Exception>().With.Message.EqualTo("Student doesn't have an unique id."));
        }

        [Test]
        public void GivenId_WheIdValid_ThenDeleteStudent()
        {
            schoolContext = new SchoolContext();
            //Given
            Student student = new Student()
            {
                Id= "60f6a6fc-9de7-4fca-b75c-f6f335c76961",
                FirstName = "Carson",
                LastName = "Alexander",
                Enrollments = new List<Enrollment>()
            };
            var count = studentController.GetAll().Count();

            //When
            studentController.Delete(mockedSchoolContext.Object.Students[0]);
            var countResult = studentController.GetAll().Count();

            //Assert
            Assert.AreNotEqual(countResult, count);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GradeBook.GradeBooks;
using GradeBook;

namespace GradeBookTests
{
    public class GetLetterGradeTests
    {
        [Fact]
        public void GetLetterGradeTest()
        {
            //arrange
            var grade = new RankedGradeBook("testGrades", true);
            var joao = new Student("joao", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(joao);
            grade.AddGrade("joao", 90);

            var jose = new Student("jose", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(jose);
            grade.AddGrade("jose", 70);

            var maria = new Student("maria", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(maria);
            grade.AddGrade("maria", 50);

            var chico = new Student("chico", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(chico);
            grade.AddGrade("chico", 30);

            var ricardo = new Student("ricardo", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(ricardo);
            grade.AddGrade("ricardo", 10);

            var sastre = new Student("sastre", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(sastre);
            grade.AddGrade("sastre", 65);

            var tiago = new Student("tiago", GradeBook.Enums.StudentType.Standard, GradeBook.Enums.EnrollmentType.Campus);
            grade.AddStudent(tiago);
            grade.AddGrade("tiago", 95);

            //act
            var result = grade.GetLetterGrade(sastre.AverageGrade);
            var result2 = grade.GetLetterGrade(joao.AverageGrade);
            var result3 = grade.GetLetterGrade(ricardo.AverageGrade);

            //assert
            Assert.Equal('C', result);
            Assert.Equal('A', result2);
            Assert.Equal('F', result3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            Type = GradeBookType.Ranked;
            IsWeighted = isWeighted;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            else
            {
                double percent = ((double)(Students.Where(g => g.AverageGrade > averageGrade).Count()) /(Students.Count() - 1))*100;

                if (percent < 20.0)
                    return ('A');
                if (percent < 40.0)
                    return ('B');
                if (percent < 60.0)
                    return ('C');
                if (percent < 80.0)
                    return ('D');
                else
                    return ('F');
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine($"Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine($"Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}

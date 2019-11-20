using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) //TODO
        {
            char grade = ' ';
            if (Students.Count < 5)
                throw new InvalidOperationException();
            else if (averageGrade <= 0.2 * Students.Count)
                grade =  'A';
            else if (averageGrade > 0.2 * Students.Count && averageGrade <= 0.4 * Students.Count)
                grade =  'B';
            else if (averageGrade > 0.4 * Students.Count && averageGrade <= 0.6 * Students.Count)
                grade =  'C';
            else if (averageGrade > 0.6 * Students.Count && averageGrade <= 0.8 * Students.Count)
                grade =  'D';
            else if (averageGrade > 0.8 * Students.Count)
                grade = 'F';
            return grade;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}

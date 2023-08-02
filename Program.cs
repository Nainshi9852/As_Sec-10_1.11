using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class StudentGradeCard
    {
        public string StudentName { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }

        public virtual void DisplayGradeCard()
        {
            Console.WriteLine($"Student: {StudentName}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine($"Obtained Marks: {ObtainedMarks}");
        }
    }

    class PrimaryStudentGradeCard : StudentGradeCard
    {
        public int SportsMarks { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"Sports Marks: {SportsMarks}");
        }
    }

    class MiddleSchoolStudentGradeCard : StudentGradeCard
    {
        public int ScienceMarks { get; set; }
        public int SocialStudiesMarks { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"Science Marks: {ScienceMarks}");
            Console.WriteLine($"Social Studies Marks: {SocialStudiesMarks}");
        }
    }

    class HighSchoolStudentGradeCard : StudentGradeCard
    {
        public int PhysicsMarks { get; set; }
        public int ChemistryMarks { get; set; }
        public int BiologyMarks { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"Physics Marks: {PhysicsMarks}");
            Console.WriteLine($"Chemistry Marks: {ChemistryMarks}");
            Console.WriteLine($"Biology Marks: {BiologyMarks}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentGradeCard primaryStudent = new PrimaryStudentGradeCard
            {
                StudentName = "Alice",
                TotalMarks = 300,
                ObtainedMarks = 270,
                SportsMarks = 25
            };

            StudentGradeCard middleSchoolStudent = new MiddleSchoolStudentGradeCard
            {
                StudentName = "Bob",
                TotalMarks = 500,
                ObtainedMarks = 430,
                ScienceMarks = 90,
                SocialStudiesMarks = 80
            };

            StudentGradeCard highSchoolStudent = new HighSchoolStudentGradeCard
            {
                StudentName = "Charlie",
                TotalMarks = 600,
                ObtainedMarks = 520,
                PhysicsMarks = 95,
                ChemistryMarks = 90,
                BiologyMarks = 85
            };

            StudentGradeCard[] gradeCards = { primaryStudent, middleSchoolStudent, highSchoolStudent };

            foreach (var gradeCard in gradeCards)
            {
                Console.WriteLine("\n--- Grade Card ---");
                gradeCard.DisplayGradeCard();
            }

            Console.ReadLine();
        }
    }
}

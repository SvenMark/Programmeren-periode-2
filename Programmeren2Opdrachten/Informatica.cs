using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren2Opdrachten
{
    public class Student
    {
        public int StudentNr { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int VakNr { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }

    public class Exam
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public decimal Score { get; set; }
    }

    public class TentamenCijfers
    {
        private static Student jan =        new Student() { StudentNr = 1, Name = "Jan" };
        private static Student piet =       new Student() { StudentNr = 2, Name = "Piet" };
        private static Student klaas =      new Student() { StudentNr = 3, Name = "Klaas" };
        private static Student katrijn =    new Student() { StudentNr = 4, Name = "Katrijn" };

        private static List<Student> students = new List<Student>() {
            jan, piet, klaas, katrijn
        };

        private static Course cSharp =  new Course() { VakNr = 1, Name = "C#", Teacher = "Joris" };
        private static Course math =    new Course() { VakNr = 2, Name = "Wiskunde", Teacher = "Jos" };
        private static Course coo =     new Course() { VakNr = 3, Name = "Computer Organisation", Teacher = "Sibbele" };
        private static Course se =      new Course() { VakNr = 3, Name = "Software Engineering", Teacher = "David" };
        private static Course python  = new Course() { VakNr = 3, Name = "Python", Teacher = "Wouter" };

        private static List<Course> courses = new List<Course>() {
            cSharp, math, coo
        };

        private static List<Exam> exams = new List<Exam>() {
            new Exam() { Student = jan,       Course = math,      Score = 3 },
            new Exam() { Student = piet,      Course = math,      Score = 5 },
            new Exam() { Student = jan,       Course = coo,       Score = 7 },
            new Exam() { Student = klaas,     Course = cSharp,    Score = 9 },
            new Exam() { Student = jan,       Course = cSharp,    Score = 5 },
            new Exam() { Student = jan,       Course = math,      Score = 6 },
            new Exam() { Student = katrijn,   Course = cSharp,    Score = 6 },
            new Exam() { Student = katrijn,   Course = coo,       Score = 6 },
            new Exam() { Student = piet,      Course = math,      Score = 8 },
            new Exam() { Student = piet,      Course = coo,       Score = 5 },
            new Exam() { Student = katrijn,   Course = se,        Score = 8 },
            new Exam() { Student = katrijn,   Course = se,        Score = 9.5m }
        };

        //Geef alle scores van een student, gebruik als argument de student naam
        [Test]
        public static void TestGetScoreByStudentName()
        {
            //schrijf je eigen test cases

        }

        public static List<decimal> GetScoreByStudentName(string name) {
            throw new NotImplementedException();
        }

        //Bepaal het hoogste behaalde resultaat van een student, gebruik als argument de student naam
        [Test]
        public static void TestGetHighestScoreByStudentName()
        {
            //schrijf je eigen test cases
        }

        public static decimal GetHighestScoreByStudentName(string name)
        {
            throw new NotImplementedException();
        }

        //Welke studenten hebben alleen maar voldoendes gehaald?
        [Test]
        public static void TestGoodStudents()
        {
            //schrijf je eigen test cases
        }

        public static List<Student> GoodStudents()
        {
            throw new NotImplementedException();
        }

        //Voor welke vak zijn de meeste toetsen gedaan?
        [Test]
        public static void TestMostExamsByCourse()
        {
            //schrijf je eigen test cases
        }

        public static Course MostExamsByCourse()
        {
            throw new NotImplementedException();
        }

        //Bepaal voor iedere student zijn gemiddelde score 
        //Pittig
        [Test]
        public static void TestGetAverageScoreByStudent()
        {
            //schrijf je eigen test cases
        }

        public class StudentAverage
        {
            public String Name { get; set; }
            public decimal Score { get; set; }
        }

        public static List<StudentAverage> GetAverageScoreByStudent(string name)
        {
            throw new NotImplementedException();
        }

        //Pittig: Hoeveel herkansingen zijn er gedaan?
        //Een herkansing is een toest die nog een keer is gedaan door dezelfde student
        [Test]
        public static void TestNumberOfResits()
        {
            //schrijf je eigen test cases
        }
        
        public int NumberOfResits()
        {
            throw new NotImplementedException();
        }
    }
}

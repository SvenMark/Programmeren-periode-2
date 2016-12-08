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
        private static Course se =      new Course() { VakNr = 4, Name = "Software Engineering", Teacher = "David" };
        private static Course python  = new Course() { VakNr = 5, Name = "Python", Teacher = "Wouter" };

        private static List<Course> courses = new List<Course>() {
            cSharp, math, coo, se, python
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
            List<decimal> list = new List<decimal>() { 3, 7, 5, 6 };
            string studentNaam = "jan";
            Assert.AreEqual(list, GetScoreByStudentName(studentNaam));
        }

        public static List<decimal> GetScoreByStudentName(string name) {
            List<decimal> scores = new List<decimal>();
            foreach (Exam e in exams)
            {
                if (e.Student.Name.ToLower() == name.ToLower())
                {
                    scores.Add(e.Score);
                }
            }
            return scores;
        }

        //Bepaal het hoogste behaalde resultaat van een student, gebruik als argument de student naam
        [Test]
        public static void TestGetHighestScoreByStudentName()
        {
            Assert.AreEqual(7 , GetHighestScoreByStudentName("jan"));
        }

        public static decimal GetHighestScoreByStudentName(string name)
        {
            decimal biggest = 0;
            foreach (Exam e in exams)
            {
                if (e.Student.Name.ToLower() == name.ToLower())
                {
                    if (e.Score > biggest)
                    {
                        biggest = e.Score;
                    }
                }
            }
            return biggest;
        }
    

        //Welke studenten hebben alleen maar voldoendes gehaald?
        [Test]
        public static void TestGoodStudents()
        {
            List<Student> list = new List<Student>() {klaas, katrijn};
            Assert.AreEqual(list, GoodStudents());
        }

        public static List<Student> GoodStudents()
        {
            List<Student> GoedeLijst = new List<Student>();
            foreach (Student s in students)
            {
                bool good = false;
                foreach (Exam e in exams)
                {
                    if (s.Name.ToLower() == e.Student.Name.ToLower())
                    {
                        if (e.Score >= 5.5m)
                        {
                            good = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (good == true)
                {
                    GoedeLijst.Add(s);
                }
            }
            return GoedeLijst;
        }

        //Voor welke vak zijn de meeste toetsen gedaan?
        [Test]
        public static void TestMostExamsByCourse()
        {
            Assert.AreEqual(math, MostExamsByCourse());
        }

        public static Course MostExamsByCourse()
        {
            Course biggest = null;
            int grootste = 0;
            foreach (Course c in courses)
            {
                int count = 0;
                foreach (Exam e in exams)
                {
                    if (c.Name == e.Course.Name)
                    {
                        count++;
                    }
                }
                if (count > grootste)
                {
                    grootste = count;
                    biggest = c;
                }
            }
            return biggest;
        }

        //Bepaal voor iedere student zijn gemiddelde score 
        //Pittig
        [Test]
        public static void TestGetAverageScoreByStudent()
        {
            //Assert.AreEqual(5.25, GetAverageScoreByStudent("jan"));
        }

        public class StudentAverage
        {
            public String Name { get; set; }
            public decimal Score { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is StudentAverage)
                {
                    StudentAverage s = (StudentAverage)obj;
                    return Name == s.Name && Score == s.Score;
                }
                else
                {
                    return false;
                }
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode() + Score.GetHashCode();
            }
        }

        public static List<StudentAverage> GetAverageScoreByStudent(string name)
        {
                decimal total = 0;
                int count = 0;
                foreach (Exam e in exams)
                {
                    if (name.ToLower() == e.Student.Name.ToLower())
                    {
                        total += e.Score;
                        count++;
                    }
                }
                decimal avg = total / count;
                List<StudentAverage> avgList = new List<StudentAverage>()
                {
                    new StudentAverage() {Name = name, Score = avg}
                };
                return avgList;
        }

        //Pittig: Hoeveel herkansingen zijn er gedaan?
        //Een herkansing is een toest die nog een keer is gedaan door dezelfde student
        [Test]
        public static void TestNumberOfResits()
        {
            Assert.AreEqual(3, NumberOfResits());
        }
        
        public static int NumberOfResits()
        {
            int herkansingen = 0;
            foreach (Course c in courses)
            {
                foreach (Student s in students)
                {
                    int count = 0;
                    foreach (Exam e in exams)
                    {
                        if (s == e.Student && c.Name == e.Course.Name)
                        {
                            count++;
                        }
                    }
                    if (count >= 2)
                    {
                        herkansingen++;
                    }
                }
            }
            return herkansingen;
        }
    }
}

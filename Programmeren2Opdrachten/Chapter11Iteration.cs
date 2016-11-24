using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren2Opdrachten
{
    class Chapter11Iteration
    {
        //Write a method to count how many odd numbers are in an array.
        [Test]
        public void TestExercise1()
        {
            Programmeren2Tests.Chapter11Test.TestExercise1(Exercise1);
        }

        public static int Exercise1(int[] xs)
        {
            int teller = 0;
            for (int i = 0; i < xs.Length; i++)
            {
                if (xs[i] % 2 != 0)
                {
                    teller++;
                }
            }
            return teller;
        }

        //Sum up all the even numbers in an array.
        [Test]
        public void TestExercise2()
        {
            Programmeren2Tests.Chapter11Test.TestExercise2(Exercise2);
        }

        public static int Exercise2(int[] xs)
        {
            int totaal = 0;
            foreach (var x in xs)
            {
                if (x % 2 == 0)
                {
                    totaal += x;
                }
            }
            return totaal;
        }


        //Sum up all the negative numbers in an array.
        [Test]
        public void TestExercise3()
        {
            Programmeren2Tests.Chapter11Test.TestExercise3(Exercise3);
        }

        public static int Exercise3(int[] xs)
        {
            int totaal = 0;
            foreach (var x in xs)
            {
                if (x < 0)
                {
                    totaal += x;
                }
            }
            return totaal;
        }

        //Count how many words in an array have length 5. (Use help to find out how to determine the length of a string.)
        [Test]
        public void TestExercise4()
        {
            Programmeren2Tests.Chapter11Test.TestExercise4(Exercise4);
        }

        public static int Exercise4(string[] xs)
        {
            int count = 0;
            foreach (var x in xs)
            {
                if (x.Length == 5)
                {
                    count++;
                }
            }
            return count;
        }


        //Sum all the elements in an array up to but not including the first even number. 
        //(Write your unit tests. What about the case when there is no even number?)
        [Test]
        public void TestExercise5()
        {
            Programmeren2Tests.Chapter11Test.TestExercise5(Exercise5);
        }

        public int Exercise5(int[] xs)
        {
            int totaal = 0;
            foreach (var x in xs)
            {
                if (x % 2 == 0)
                {
                    break;
                }

                totaal += x;
            }
            return totaal;
        }

        //Count how many words occur in an array up to and including the first occurrence of the word “sam”. 
        //(Write your unit tests for this case too. Do something sensible if “sam” does not occur.)
        [Test]
        public void TestExercise6()
        {
            Programmeren2Tests.Chapter11Test.TestExercise6(Exercise6);
        }

        public int Exercise6(string[] xs)
        {
            int count = 0;
            foreach (string x in xs)
            {
                count++;
                if (x == "sam")
                {
                    break;
                }
            }
            return count;
        }

        //Add a print statement to Newton’s sqrt method to show better each time it is calculated. 
        //In Testprogramma kan je geen Console.WriteLine gebruiken, maar wel:
        //System.Diagnostics.Debug.WriteLine(better);
        //Call your modified method with 25 as an argument and record the results.
        //Write down the result in comments
        //This is not a real test, but rather an exercise in tracing

        //Extra assignment: try to capture the values of the variable better with the debugging 
        //facilities from Visual Studio 

        [Test]
        public void TestExercise7()
        {
            sqrt(25);
        }

        public static double sqrt(double n)
        {
            double approx = n / 2.0;     // Start with some or other guess at the answer
            while (true)
            {
                double better = (approx + n / approx) / 2.0;
                if (Math.Abs(approx - better) < 0.001)
                {
                    System.Diagnostics.Debug.WriteLine(better);
                    return better;
                }
                approx = better;
            }
        }

        //Trace the execution of the last version of generateTable and make yourself more 
        //comfortable with single stepping, and debugging.
        [Test]
        public void TestExercise8()
        {
            generateMultiplicationTable(5);
        }

        public static void generateMultiplicationTable(int sz)
        {
            for (int r = 1; r <= sz; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    System.Diagnostics.Debug.Write(string.Format("{0,5}", r * c));
                }
                System.Diagnostics.Debug.Write("\n");
            }
        }

        //Write a method that prints the n-th triangular numbers. 
        //A call to triangular_numbers(5) would produce the following output: 15
        //https://en.wikipedia.org/wiki/Triangular_number
        [Test]
        public void TestExercise9()
        {
            Assert.AreEqual(Exercise9(5), 15);
        }

        public static int Exercise9(int n)
        {
            int dots = 1;
            int Tn = 1;
            for (int i = 1; i < n; i++)
            {
                System.Diagnostics.Debug.Write(Tn + " " + dots);
                Tn++;
                dots += Tn;

            }
            return dots;
        }


        //What happens if we call our Collatz sequence generator with a negative integer?
        //De - kan met /2 en *3 niet plus worden dus wordt het nooit 1 dus blijft de loop infinite doorgaan

        //What happens if we call it with zero?
        //Als je nul deelt of vermenigvuldigt blijft het 0 dus ook altijd ongelijk aan 1 en gaat de loop infinite door

        //Change the method so that it outputs an error message in either of these cases, and doesn’t get into an infinite loop.
        public static void TestExercise10()
        {
            //Collatz(-10);
            //Collatz(0);
        }

        private static void Collatz(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Error");
                Console.ReadKey();      
            }
            while (n != 1)
            {
                Console.Write("{0}, ", n);
                if (n % 2 == 0)        // n is even
                {
                    n /= 2;
                }
                else                  // n is odd
                {
                    n = n * 3 + 1;
                }
            }
            Console.WriteLine("{0}. Yes, it got to 1!", n);
            Console.ReadKey();
        }

        //Write a method, isPrime, which takes a single integer argument and returns true 
        //when the argument is a prime number and false otherwise. 
        //Add tests for cases like this:
        //The last cases could represent your birth date. 
        //Were you born on a prime day? In a class of 100 students, how many do you think would have prime birth dates?
        //1/3
        [Test]
        public void TestExercise11()
        {
            Exercise11(11);
            Programmeren2Tests.Chapter11Test.TestExercise11(Exercise11);
        }

        public static bool Exercise11(int n)
        {
            if (n < 2)
            {
                return false;
            }

            else if (n == 2)
            {
                return true;
            }

            else if (n % 2 == 0)
            {
                return false;
            }
            else
            {
                int i;
                for (i = 3;  n % i != 0; i += 2);
                if (i == n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //What will num_digits(0) return? Modify it to return 1 for this case. 
        //0
        //Does a call to num_digits(-12345) work? 
        //Ja
        //Trace through the execution and see what happens if you start with a negative number. 
        //Modify num_digits so that it works correctly with any integer value. 
        //Add these tests:
        [Test]
        public void TestExercise15()
        {
            //num_digits(0);
            //num_digits(-12345);
        }

        public static int num_digits(int n)
        {
            int count = 0;
            if (n == 0)
            {
                return 1;
            }
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        [Test]
        //Without making use of strings, write a method numEvenDigits(n) that counts 
        //the number of even digits in n. Here are some tests that should pass:
        //Remark: don't use conversions/casts, i.e. don't use strings!
        public void TestExercise16()
        {
            Assert.AreEqual(NumEvenDigits(123456), 3);
            Assert.AreEqual(NumEvenDigits(2468), 4);
            Assert.AreEqual(NumEvenDigits(1357), 0);
            //// Normally we never put leading zeros on numbers, but our number
            //// system has a special case that probably needs special case handling in the code.
            Assert.AreEqual(NumEvenDigits(0), 1);
            Assert.AreEqual(NumEvenDigits(0002468), 4);
            Assert.AreEqual(NumEvenDigits(-12345), 2);
            Assert.AreEqual(NumEvenDigits(-2468), 4);

            Programmeren2Tests.Chapter11Test.TestExercise16(NumEvenDigits);
        }

        public static int NumEvenDigits(int n)
        {
            int even = 0;
            int calc = 0;
            if (n == 0)
            {
                even++;
            }
            while (n > 0 || n < 0)
            {
                calc = n % 2;
                if (calc == 0)
                {
                    even++;
                }
                n = n / 10;
            }
            return even;
        }

        //Write a method sum_of_squares(xs) that computes the sum of the squares of the numbers in the array xs. For example, 
        //sum_of_squares(new double[] {2, 3, 4}) should return 4+9+16 which is 29:
        [Test]
        public void TestExercise17()
        {
            Programmeren2Tests.Chapter11Test.TestExercise17(Exercise17);
        }

        public static double Exercise17(double[] xs)
        {
            //xs = new double[] { 2, 3, 4 };
            double sum_of_squares = 0;
            foreach (double x in xs)
            {
                sum_of_squares += Math.Pow(x, 2);
            }
            return sum_of_squares;
        }
    }
}

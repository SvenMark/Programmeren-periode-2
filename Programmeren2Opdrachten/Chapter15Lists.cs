using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Programmeren2Opdrachten
{
    class Chapter15Lists
    {
        //1. Consider this fragment of code:
        //    List<int> xs = new List<int>();
        //    List<int> ys = xs;
        //    ys.Add(42);
        //Does this create one or two list instances? Would would the value of xs.Count be after executing this code?


        //2. What will be the output of the following program?
        //string[] us = { "I", "am", "not", "a", "crook" };
        //string[] vs = { "I", "am", "not", "a", "crook" };
        //Console.WriteLine("Test 1: {0}",  us == vs);
        //us = vs;
        //Console.WriteLine("Test 2: {0}", us == vs);
        //Provide a detailed explanation of the results.
        
        //3a Write a deep equality test for two arrays of string so that these unit tests pass:
        [Test]
        public void TestExercise3a()
        {
            string[] us = { "I", "am", "not", "a", "crook" };
            string[] vs = { "I", "am", "not", "a", "crook" };
            string[] ws = { "I", "am", "a", "crook" };
            string[] xs = { "I", "am", "not", "a", "cowboy" };
            Assert.AreEqual(true, Exercise3a(us, vs));
            Assert.AreEqual(false, Exercise3a(us, ws));
            Assert.AreEqual(false, Exercise3a(us, xs));
            Assert.AreEqual(true, Exercise3a(xs, xs));
        }

        public static bool Exercise3a(string[] xs, string[] ys)
        {
            throw new NotImplementedException();
        }

        //3b Now do the same for a deep equality test for List<string>.
        [Test]
        public void TestExercise3b()
        {
            List<string> us = new List<string> { "I", "am", "not", "a", "crook" };
            List<string> vs = new List<string> { "I", "am", "not", "a", "crook" };
            List<string> ws = new List<string> { "I", "am", "a", "crook" };
            List<string> xs = new List<string> { "I", "am", "not", "a", "cowboy" };
            Assert.AreEqual(true, Exercise3b(us, vs));
            Assert.AreEqual(false, Exercise3b(us, ws));
            Assert.AreEqual(false, Exercise3b(us, xs));
            Assert.AreEqual(true, Exercise3b(xs, xs));
        }

        public static bool Exercise3b(List<string> xs, List<string> ys)
        {
            throw new NotImplementedException();
        }

        //4a Write two methods that remove all the odd numbers from a list. 
        //The first method should build a new list containing only the even elements. 
        //The second method should do an in-place change to the original list.
        [Test]
        public void TestExercise4a()
        {
            List<int> xs = new List<int>() { 3, 5, 4, 7, 2 };
            Assert.AreEqual(new List<int>() { 4, 2 }, RemoveOdds1(xs));
            Assert.AreEqual(new List<int>() { }, RemoveOdds1(new List<int>() { }));
            Assert.AreEqual(new List<int>() { 3, 5, 4, 7, 2 }, xs);

            RemoveOdds2(xs);
            Assert.AreEqual(new List<int>() { 4, 2 }, xs);

            List<int> ys = new List<int>() { 3, 5, 7, 9, 11, 13, 15 };
            RemoveOdds2(ys);
            Assert.AreEqual(new List<int>() { }, ys);
        }

        public static List<int> RemoveOdds1(List<int> xs)
        {
            throw new NotImplementedException();
        }

        public static void RemoveOdds2(List<int> xs)
        {
            throw new NotImplementedException();
        }

        //5 Write a method moveToBack(xs, p). 
        //The p’th element of the list should “lose its place” and go to the back of the list. 
        //If p is out of bounds, no changes are made. This should be an in-place update.
        [Test]
        public void TestExercise5()
        {
            List<int> xs = new List<int>() { 30, 50, 40, 70, 20 };
            MoveToBack(xs, 2);         // move element at position 2 to the back
            Assert.AreEqual(new List<int>() { 30, 50, 70, 20, 40 }, xs);
            MoveToBack(xs, 0);
            MoveToBack(xs, -1);
            MoveToBack(xs, 4);
            MoveToBack(xs, 5);
            MoveToBack(xs, 2);
            Assert.AreEqual(new List<int>() { 50, 70, 40, 30, 20 }, xs);
        }

        public static void MoveToBack(List<int> xs, int p)
        {
            throw new NotImplementedException();    
        }

        //6 Re-do the above exercise, this time with fixed-size arrays. 
        //You may not use a list for the logic, 
        //nor are you allowed to attempt to resize the array.
        [Test]
        public void TestExercise6()
        {
            int[] xs = { 30, 50, 40, 70, 20 };
            MoveToBack(xs, 2);         // move element at position 2 to the back
            Assert.AreEqual(new int[] { 30, 50, 70, 20, 40 }, xs);
            MoveToBack(xs, 0);
            MoveToBack(xs, -1);
            MoveToBack(xs, 4);
            MoveToBack(xs, 5);
            MoveToBack(xs, 2);
            Assert.AreEqual(new int[] { 50, 70, 40, 30, 20 }, xs);
        }

        public static void MoveToBack(int[] xs, int p)
        {
            throw new NotImplementedException();
        }

        //7 Write a method that deletes any items in a List<int> that are smaller 
        //than their immediate predecessor in the original list. 
        //The list should be mutated: do not build a new list of items. Study the tests carefully to make sure you understand the requirements.
        //You should try this problem in two ways and compare the code you get. In the first case, work backwards, 
        //starting at the last element of the list, and deciding if it needs to be deleted. 
        //Then work towards the front of the list.
        //In the second variation, use a while loop to start at the left and work to the end. This is more difficult!
        
       
        [Test]
        public void TestExercise7()
        {
            List<int> xs = new List<int>() { 12, 16, 14, 14, 16, 18, 11, 9, 12, 4, 2 };
            Exercise7a(xs);
            Assert.AreEqual(new List<int>() { 12, 16, 14, 16, 18, 12 }, xs);
            Exercise7a(xs);
            Assert.AreEqual(new List<int>() { 12, 16, 16, 18 }, xs);

            xs = new List<int>() { 12, 16, 14, 14, 16, 18, 11, 9, 12, 4, 2 };
            Exercise7b(xs);
            Assert.AreEqual(new List<int>() { 12, 16, 14, 16, 18, 12 }, xs);
            Exercise7b(xs);
            Assert.AreEqual(new List<int>() { 12, 16, 16, 18 }, xs);
        }

        public static void Exercise7a(List<int> xs)
        {
            throw new NotImplementedException();   
        }
        
        public static void Exercise7b(List<int> xs)
        {
            throw new NotImplementedException();   
        }

        //Voor tekst en uitleg zie blackboard, opdracht aftelversje
        //Tip: gebruik een lijst
        [Test]
        public static void TestAftelVersje()
        {
            Assert.AreEqual(3, AftelVersje(2, 5));

            Programmeren2Tests.Chapter15Test.TestAftelVersje(AftelVersje);
        }

        public static int AftelVersje(int aantalLettergrepen, int aantalKinderen)
        {
            throw new NotImplementedException();
        }
    }
}

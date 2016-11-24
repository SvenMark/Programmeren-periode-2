using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Programmeren2Opdrachten
{
	public class Chapter12Strings
	{
        //1 What is the value of each of the following expressions, Explain:
        //"C#"[1] = #
        //"C#"[2] = error
        //"Strings are sequences of characters."[5] = g
        //"wonderful".Length = 9
        //"app" + "le" = apple
        //"appl" + 'e' = apple
        //"Mystery".Substring(4) = ery
        //"Mystery".Substring(4, 2) = er
        //"Mystery".IndexOf('y') = 6
        //"Mystery".IndexOf('z') = error
        //"Mystery".IndexOf('y',3) = 4
        //"Mystery".IndexOf('y',3, 2) = 6
        //"apple".CompareTo("pineapple") > 0 = false
        //"pineapple".CompareTo("Peach") == 0 = error

        //2  Encapsulate:
        // First parameter is the string (fruit)
        // Second paramter is the char ('a')
        // The Code
        //string fruit = "banana";
        //int count = 0;
        //foreach (char c in fruit)
        //{
        //    if (c  == 'a')
        //        count += 1;
        //}
        //Console.WriteLine(count);
        //in a method named count_letters, and generalize it so that it accepts the string and the letter as arguments. 
        //Make the method return the number of characters, rather than show the answer.

        //[Test]
        public void TestExercise2()
        {
            //uncomment next line to test your methode!
            Programmeren2Tests.Chapter12Test.TestExercise3(CountLetters);
        }

        //change the return type and paramaters
        public static int CountLetters(string s, char chr)
        {
            string fruit = "banana";
            int count = 0;
            foreach (char c in fruit)
            {
                if (c  == 'a')
                    count += 1;
            }
            return count;
        }

        //3 Now rewrite the count_letters (see above) method so that instead of traversing the string, 
        //it repeatedly calls the IndexOf method, with the optional third parameter to locate new occurrences of the letter being counted.
        [Test]
		public void TestExercise3()
		{
            Programmeren2Tests.Chapter12Test.TestExercise3(Exercise3);       
		}

        public static int Exercise3(string s, char chr) 
        {
            if (string.IsNullOrWhiteSpace(s) || char.IsWhiteSpace(chr))
            {
                return 0;
            }
            int count = 0;
            int idx = 0;
            while ((idx = s.IndexOf(chr, idx)) != -1)
            {
                count++;
                idx++;
            }
            return count;
        }
        
		public static int IndexOf(string str, char ch, int startPos)
		{
            for (int ix = startPos; ix < str.Length; ix++) 
            {
                if (str[ix] == ch)
                {
                    return ix;
                }
            }

			return -1;
		}

        public static int IndexOf(string str, string sub, int startPos)
        {
            int end = str.Length - sub.Length + 1;
            for (int ix = startPos; ix < end; ix++)
            {
                bool found = true;
                for (int si = 0; si < sub.Length; si++)
                {
                    if(str[ix+si] != sub[si])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return ix;
                }
            }

            return -1;
        }


        //4 How many times does “queen” occur in the Alice in Wonderland book? Write some code to count them.
		[Test]
		public void TestExercise4()
		{
            Programmeren2Tests.Chapter12Test.TestExercise4(Exercise4);
            
		}

        public static int Exercise4()
        {
            string text = LoadAliceInWonderland();
            Regex r = new Regex("queen", RegexOptions.IgnoreCase);
            int count = r.Matches(text).Count;
            return count;

            //int count = 0;
            //string book = LoadAliceInWonderland();
            //string cleanedString = remove_punctuation(book);
            //string[] words = cleanedString.Split();
            //foreach (string w in words)
            //{
            //    string woord = w.ToLower();
            //    if (woord == "queen")
            //    {
            //        count++;
            //    }
            //}
            //return count;
        }

        public static string remove_punctuation(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                {
                    result += c;                 // This step is inefficient!
                }
            }
            return result;
        }

        //load the book (from file) and return it as a string array
        public static string LoadAliceInWonderland()
		{
            string aliceFile = Path.Combine(Environment.CurrentDirectory, "bestanden\\alice_in_wonderland.txt");
            return File.ReadAllText(aliceFile);
		}

		//5. Use string formatting to produce a neat looking multiplication table like this:
        //        1   2   3   4   5   6   7   8   9  10  11  12
        //  :--------------------------------------------------
        // 1:     1   2   3   4   5   6   7   8   9  10  11  12
        // 2:     2   4   6   8  10  12  14  16  18  20  22  24
        // 3:     3   6   9  12  15  18  21  24  27  30  33  36
        // 4:     4   8  12  16  20  24  28  32  36  40  44  48
        // 5:     5  10  15  20  25  30  35  40  45  50  55  60
        // 6:     6  12  18  24  30  36  42  48  54  60  66  72
        // 7:     7  14  21  28  35  42  49  56  63  70  77  84
        // 8:     8  16  24  32  40  48  56  64  72  80  88  96
        // 9:     9  18  27  36  45  54  63  72  81  90  99 108
        //10:    10  20  30  40  50  60  70  80  90 100 110 120
        //11:    11  22  33  44  55  66  77  88  99 110 121 132
        //12:    12  24  36  48  60  72  84  96 108 120 132 144
		public static void MultiplicationTable()
		{
            int i = 0;
            Console.Write("\t");
            while (i < 12)
            {
                i++;
                Console.Write("{0}\t", i);
            }
            Console.Write("\n");
            Console.Write(":--------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            for (int row = 1; row <= 12; row++)
            {
                Console.Write("{0}:\t", row);
                for (int col = 1; col <= 12; col++)
                {
                    Console.Write("{0}\t", (row * col));
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }

		//6. Write a method that reverses its string argument, and satisfies these tests:
        //Remark: don't call any other methods!
		[Test]
		public void TestExercise6() 
        {
            Programmeren2Tests.Chapter12Test.TestExercise6(Exercise6);
		}

        public string Exercise6(string str)
        {
            string revstr = "";
            for (int i = str.Length - 1; i >=  0; i--)
            {
                revstr += str[i];
            }
            return revstr;
        }

		//7. Write a method that mirrors its argument:
        //Assert.AreEqual(mirror("good"), "gooddoog");
        //Assert.AreEqual(mirror("C#"), "C##C");
        //Assert.AreEqual(mirror(""), "");
        //Assert.AreEqual(mirror("a"), "aa");
        // Dick: het laatste testgeval geeft een rare melding ..PSystem.Linq.Enumerable..
        // Dick: string.Reverse() geeft een Iterator ipv een omgekeerde string
        // Joris: nu aangepast
        //Remark: don't call any other methods!
 		[Test]
		public void TestExercise7()
		{
            Assert.AreEqual(Exercise7("good"), "gooddoog");
            Assert.AreEqual(Exercise7("C#"), "C##C");
            Assert.AreEqual(Exercise7(""), "");
            Assert.AreEqual(Exercise7("a"), "aa");
        }

        public static string Exercise7(string s)
		{
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i];
            }

            string mirror = s + revs;
            return mirror;
        }

		//8. Write a method that removes all occurrences of a given letter from a string:
		[Test]
        public void TestExercise8()
		{
            Programmeren2Tests.Chapter12Test.TestExercise8(Exercise8);
		}

        public static string Exercise8(char chr, string s)
		{
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == chr)
                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }
            return s;

            //string new_string = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] != chr)
            //    {
            //        new_string += s[i];
            //    }
            //}
            //return new_string;
        }


        //9. Write a method that recognizes palindromes. (Hint: use your reverse method to make this easy!):
        [Test]
		public void TestExercise9()
		{
			Assert.AreEqual(IsPalindrome("abba"), true);
			Assert.AreEqual(IsPalindrome("abab"), false);
			Assert.AreEqual(IsPalindrome("tenet"), true);
			Assert.AreEqual(IsPalindrome("banana"), false);
			Assert.AreEqual(IsPalindrome("straw warts"), true);
			Assert.AreEqual(IsPalindrome("a"), true);
			//A palindrome must consist of at least one character (after removing punctuation and white space).
			Assert.AreEqual(IsPalindrome(""), false, "A palindrome must consist of at least one character (after removing punctuation and white space).");    // Is an empty string a palindrome?  You decide.
		}

		public static bool IsPalindrome(string s)
		{
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i];
            }

            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            if (s == revs)
            {
                return true;
            }

            else return false;
        }

		//10 Write a method that counts how many times a substring occurs in a string:
		[Test]
		public void TestExercise10()
		{
            Programmeren2Tests.Chapter12Test.TestExercise10(Exercise10);
		}

		public static int Exercise10(string sub, string str) 
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrWhiteSpace(sub))
            {
                return 0;
            }
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(sub, index)) != -1)
            {
                count++;
                index++;
            }
            return count;
        }

		//11 Write a method that removes the first occurrence of a string from another string:
		[Test]
		public void TestExercise11()
		{
            Programmeren2Tests.Chapter12Test.TestExercise11(Exercise11);
		}

        public static string Exercise11(string first, string str)
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrWhiteSpace(first))
            {
                return str;
            }
            int index;
            if ((index = str.IndexOf(first)) != -1)
            {
                str = str.Remove(index, first.Length);
            }
            return str;
        }

		//12 Write a method that removes all occurrences of a string from another string:
		[Test]
		public void TestExercise12()
		{
            Programmeren2Tests.Chapter12Test.TestExercise12(Exercise12);
		}

        public static string Exercise12(string strToRemove, string str)
		{
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrWhiteSpace(strToRemove))
            {
                return str;
            }
            int index;
            while ((index = str.IndexOf(strToRemove)) != -1) 
            {
                str = str.Remove(index, strToRemove.Length);
            }
            return str;
        }
	}
}

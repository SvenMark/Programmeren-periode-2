using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    public class Strings
    {
        [Test]
        public void Declaration()
        {
            string myString1;        //welke waarde heeft myString?
        }

        [Test]
        public void Initalisation()
        {
            string nullString = null;
            string emptyString = "";
            //string myString3 = new string("Hello World 3!");

            string myString5 = new string('@', 10);
            char[] chrs = { 'H', 'e', 'l', 'l', 'o' };
            string myString6 = new string(chrs);
            //string myString7 = new string(myString6);


            string myString4 = "Hello World 4!";
            //voor afdrukken in console
            Console.WriteLine(myString4);
            //voor afdrukken naar output in tests
            System.Diagnostics.Debug.WriteLine(myString4);
        }

        [Test]
        public void StringConcatenation()
        {
            string s1 = "Hello";
            string s2 = "World";
            string s3 = "!";

            string h = s1 + " ";
            string hw = h + s2;
            string hwExpl = hw + s3;
        }

        [Test]
        public void StringOrString()
        {
            string s1           = string.Empty;
            System.String s2    = "";
            String s3           = String.Empty; 
        }

        [Test]
        public void StringIndexOperator()
        {
            string fruit = "banana";
            char b = fruit[0];
            char firstA = fruit[1];
            
            int numOfChars = fruit.Length;
            //char lastB = fruit[numOfChars];   //Wat voor fout (Exception) geeft dit? 
            char lastA = fruit[numOfChars - 1];
        }

        [Test]
        public void CharExample()
        {
            //char is a string of one character!
            char c = "Hello World"[2];
            //test
            char cc = 'W';
        }

        [Test]
        public void ArrayOfStrings()
        {
            string[] dayNames = {   "Sunday", "Monday", "Tuesday", "Wednesday",
                                    "Thursday", "Friday", "Saturday"};

            string s = "";
            for (int i = 0; i < dayNames.Length; i++)
            {
                s = s + dayNames[i][i];
            }
            //what is s?
        }

        [Test]
        public void StringMethods()
        {
            string hw = "Hello World!";
            hw.ToUpper();
            //wat is de waarde van hw?
        }

        [Test]
        public void SubString()
        {
            string s = "Pirates of the Caribbean";

            //wat zijn de waardes van s?
            s = s.Substring(0, 7);
            //s = s.Substring(11, 3);
            //s = s.Substring(15);
        }

        [Test]
        public void SubStringCorrect()
        {
            string s = "Pirates of the Caribbean";

            //wat zijn de waardes van s?
            string pirates = s.Substring(0, 7);
            string the = s.Substring(11, 3);
            string caribbean = s.Substring(15);
        }

        [Test]
        public void SubStringOverload()
        {
            //er zijn meerdere methoden Substring(...)
            //alleen de paramaterlijst is anders, 
            //dit noemen we overloads (overloaded)

            string s = "Pirates of the Caribbean";

            string pirates = s.Substring(0, 7);
            string the = s.Substring(11, 3);
            string caribbean = s.Substring(15);
        }

        
        [Test]
        public void ChangeTheString() 
        {
            string myName = "joris";
            //myName[0] = 'J';    //Error?
        }

        [Test]
        //immutable ~= read only        (~= ongeveer gelijk aan)
        //dit betekent dat je String nooit kan/mag aanpassen!
        public void StringAreImmutable()
        {
            //oplossing voor iedere operatie maken we een nieuwe aan
            string bookName1 = "Thank Sharply!";
            string correctedName = bookName1.Substring(0, 2) + "i" + bookName1.Substring(3);

            //uitleg van het geheugen model.
            string bookName2 = "Thank Sharply!";
            bookName2 = bookName2.Substring(0, 2) + "i" + bookName2.Substring(3);
        }

        public void TraversalOfString()
        {
            string fruit = "banana";
            int i = 0;
            while (i < fruit.Length)
            {
                char c = fruit[i];
                System.Diagnostics.Debug.WriteLine(c);
                i++;
            }

            for (int j = 0; j < fruit.Length; j++)
            {
                System.Diagnostics.Debug.WriteLine(fruit[j]);
            }

            foreach (char c in fruit)
            {
                System.Diagnostics.Debug.WriteLine(c);
            }
        }

        [Test]
        public void TestCountNumberOfLetters()
        {
            Assert.AreEqual(0, CountNumberOfLetters(null, 'b'));
            Assert.AreEqual(0, CountNumberOfLetters("", 'b'));
            Assert.AreEqual(1, CountNumberOfLetters("banana", 'b'));
            Assert.AreEqual(3, CountNumberOfLetters("banana", 'a'));
            Assert.AreEqual(2, CountNumberOfLetters("banana", 'n'));
        }

        public int CountNumberOfLetters(string str, char chr)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            str = str.ToLower();
            int count = 0;
            foreach (char c in str)
            {
                if (c == chr)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountNumberOfLetters(string s)
        {
            string slc = s.ToLower();
            int count = 0;
            foreach (char c in slc)
            {
                //if(char.IsLetter(c))
                if (c >= 'a' && c <= 'z')
                {
                    count++;
                }
            }
            return count;
        }

        public void AreStringsEqual() 
        {
            string fruit = "banana";
            string word = "Hello";
            if(fruit == "banana") {} // this works
            if(word != "hello") {}    // this works
            //if (fruit <= "banana") ...  // OOPS, ERROR!

            char x = ' ';


            string word1 = "First";
            string word2 = "Second";
            string smaller;
            int cmp = word1.CompareTo(word2);
            //Opmerking if(cmp == 0) { gelijk }
            if (cmp < 0)
            {
                smaller = word1;
            }
            else
            {
                smaller = word2;
            }
            //Welke is kleiner
        }

        //het is leerzaam om een string compare te maken/bestuderen
        //je normaal kan gewoon string.Equals(s1, s2) gebruiken
        //of s1 == s2
        //of ongelijk aan s1 != s2        !string.Equals(s1,s2)

        //String.Equals return value: 
        //true if the value of a is the same as the value of b; otherwise, false. 
        //If both a and b are null, the method returns true.
        [Test]
        public void TestEquals()
        {
            Assert.AreEqual(true, MyEquals("Aap", "Aap"));
            Assert.AreEqual(false, MyEquals("Noot", "Mies"));
            Assert.AreEqual(true, MyEquals(null, null));
            Assert.AreEqual(false, MyEquals(null, "Noot"));
            Assert.AreEqual(false, MyEquals("Noot", null));
            Assert.AreEqual(false, MyEquals("Mies", "Aap"));
        }

        public bool MyEquals(string s1, string s2)
        {
            //hier kan je dus geen string.IsNullOrWhiteSpace() of string.IsNullOrWhiteSpace()
            if (s1 == null && s2 == null)
            {
                return true;
            }
            else if (s1 == null || s2 == null)
            {
                return false;
            }

            if (s1.Length != s2.Length)
            {
                return false;
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int[] CountLetterFrequency(string s) 
        {
            s = s.ToUpper();
            int[] letters = new int[26];
            foreach(char c in s) 
            {
                int index = (int)c - 65; 

                if (index >= 0 && index < 26)
                {
                    letters[index]++;
                }
            }
            return letters;
        }

        [Test]
        public void TestIndexOf() 
        {
            string str = "Hello World!";
            Assert.AreEqual(1, IndexOf(str, 'e'));
            Assert.AreEqual(4, IndexOf(str, 'o'));
            Assert.AreEqual(5, IndexOf(str, ' '));
            Assert.AreEqual(-1, IndexOf(str, 'E'));
            Assert.AreEqual(str.Length - 1, IndexOf(str, '!'));

            //Nu met startpositie
            Assert.AreEqual(-1, IndexOf(str, 'e', 3));
            Assert.AreEqual(7, IndexOf(str, 'o',5));
            Assert.AreEqual(-1, IndexOf(str, ' ', 6));
            Assert.AreEqual(9, IndexOf(str, 'l',5));
            Assert.AreEqual(str.Length - 1, IndexOf(str, '!', str.Length - 2));

            //in het echt leven vergeet de vervelende strings niet!
        }

        public int IndexOf(string value, char chr) 
        {
            int i = 0; 
            while(i < value.Length) 
            {
                if(value[i] == chr) 
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        //private int IndexOf(string strng, char ch, int startPos, int count)
        //{
        //    for (int ix = startPos; ix < startPos + count; ix++)
        //        if (strng[ix] == ch) return ix;

        //    return -1;
        //}

        //private int IndexOf(string strng, char ch, int startPos)
        //{
        //    return IndexOf(strng, ch, startPos, strng.Length - startPos);
        //}

        //private int IndexOf(string strng, char ch)
        //{
        //    return IndexOf(strng, ch, 0, strng.Length);
        //}



        //vervanging, hierbij maken we slim gebruik van overloading!
        //public static int IndexOf(string value, char chr)
        //{
        //    return IndexOf(value, char, 0);
        //}

        public int IndexOf(string value, char chr, int startPosition)
        {
            for (int i = startPosition; i < value.Length; i++)
            {
                if (value[i] == chr)
                {
                    return i;
                }
            }

            return -1;
        }


        [Test]
        public void TestOverloader()
        {
            int result0 = Sum(1, 2);
            int result1 = Sum(1, 2, 3);
            double result2 = Sum(1, 2.0, 3);
            //int     result3 = Sum(1, 2.0, 3);   //gaat dit goed?
        }

        [Test]
        public void TestSplit()
        {
            string[] parts = "Lynn;Taphorn;;22-1-1992;I1A".Split(new char[] { ';' });
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
        
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Sum(double x, double y, double z)
        {
            return x + y + z;
        }

        public  int SumReduceCode(int x, int y)
        {
            return SumReduceCode(x, y, 0);
        }

        public int SumReduceCode(int x, int y, int z)
        {
            return x + y + z;
        }

        public double SumReduceCode(double x, double y)
        {
            return SumReduceCode(x, y, 0.0);
        }

        public double SumReduceCode(double x, double y, double z)
        {
            return x + y + z;
        }

        [Test]
        public void TestHasNumber1() 
        {
            Assert.AreEqual(false, HasNumber1(" "));
            Assert.AreEqual(false, HasNumber1("Hello World"));
            Assert.AreEqual(true, HasNumber1("1"));
            Assert.AreEqual(true, HasNumber1("123"));
            Assert.AreEqual(true, HasNumber1("0"));
            Assert.AreEqual(true, HasNumber1("01"));
            Assert.AreEqual(true, HasNumber1("Hello1111World"));
            Assert.AreEqual(true, HasNumber1("Hello 90 World"));
        }

        public bool HasNumber1(string input) 
        {
            foreach (char c in input)
	        {
		        if(c >= '0' && c <= '9') 
                {
                    return true;
                }
	        }
            return false;
        }

        [Test]
        public void TestHasNumber2(string input) 
        {
            Assert.AreEqual(false, HasNumber2(""));
            Assert.AreEqual(false, HasNumber2(null));
            Assert.AreEqual(false, HasNumber2("  "));
            Assert.AreEqual(false, HasNumber2("\n\t"));
        }

        public bool HasNumber2(string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
	        {
		        if(c >= '0' && c <= '9') 
                {
                    return true;
                }
	        }
            return false;
        }

        [Test]
        public void CompareString()
        {
            String a = "First alphabetically";
            String b = "Second alphabetically";

            int cmp = String.Compare(a, b); //-1
            cmp     = String.Compare(b, a); // 1

            cmp     = String.Compare(a, a); //0
            cmp     = String.Compare(b, b); //1
        }


        public int IndexOf(string str, char chr, int startPosition, int count)
        {
            for (int i = startPosition; i < startPosition + count; i++)
            {
                if (str[i] == chr)
                {
                    return i;
                }
            }

            return -1;
        }


        //public int IndexOf(string strng, char ch, int startPos, int count)
        //{
        //    for (int ix = startPos; ix < startPos + count; ix++)
        //        if (strng[ix] == ch) return ix;

        //    return -1;
        //}

        //public int IndexOf(string strng, char ch, int startPos)
        //{
        //    return IndexOf(strng, ch, startPos, strng.Length - startPos);
        //}

        //public int IndexOf(string strng, char ch)
        //{
        //    return IndexOf(strng, ch, 0, strng.Length);
        //}

        [Test]
        public void SplitMethod()
        {
            string s = "Well I never did said Alice";
            string[] words = s.Split();
            foreach (string wd in words)
            {

            }

            //string book = System.IO.File.ReadAllText("c:\\temp\\alice_in_wonderland.txt");
            //string[] lines = book.Split('\n'); //split has many overloads

            //int numberOfLines = lines.Length;
        }

        [Test]
        public string RemovePunctuation(string s)
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
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash
//{
//    class Augnet_c2
//    {
//        static void Main(string[] args)
//        {

//            //string join
//            string[] names = { "michael", "john", "lewis" };
//            string[] lastnames = { "p", "a", "b" };
//            Array.Sort(names);
//            Array.Reverse(names);
//            string newval = String.Join(",\n", names);
//            Console.WriteLine(newval);

//            //string with the number of times it repeats
//            string fruits = "apple banana apple orange";

//            // Split the string into an array of words
//            string[] words = fruits.Split(' ');

//            // Dictionary to store word counts
//            Dictionary<string, int> wordCount = new Dictionary<string, int>();

//            // Iterate through the words and count occurrences
//            foreach (string word in words)
//            {
//                if (wordCount.ContainsKey(word))
//                {
//                    wordCount[word]++;
//                }
//                else
//                {
//                    wordCount[word] = 1;
//                }
//            }

//            // Output the word counts
//            foreach (KeyValuePair<string, int> entry in wordCount)
//            {
//                Console.WriteLine($"{entry.Key}: {entry.Value}");
//            }

//        }
//    }
//}

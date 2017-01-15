using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CS4150PS1
{
    public class MrAnaga
    {
        /// <summary>
        /// Available words
        /// </summary>
        ArrayList words;
        /// <summary>
        /// Words that are not anagrams
        /// </summary>
        HashSet<string> solutions;
        /// <summary>
        /// Words that are anagrams
        /// </summary>
        HashSet<string> rejected;

        /// <summary>
        /// Sorted version of the word
        /// </summary>
        string sortedWord;

        public static void Main (string[] args)
        {
            MrAnaga a = new MrAnaga();
            int result = a.NotAnagrams(@"C:\Users\hannal\Downloads\test2.in");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Counts the number of words that are not anagrams of other words in the dictionary.
        /// </summary>
        /// <param name="filePath">Fath of the file containing words to be sorted</param>
        /// <returns>The number of words that are not anagrams</returns>
        public int NotAnagrams(string filePath)
        {
            // Creates new instances of the collections of words
            words = new ArrayList();
            solutions = new HashSet<string>();
            rejected = new HashSet<string>();
            // Trys to open the file
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string line = "";
                    // Adds the words to the Arraylist of words
                    while ((line = sr.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }
            }
            // Catches any exceptions and displays what the exception was
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

                foreach (string word in words)
                {
                // Sorts the word alphabetically
                    sortedWord = String.Concat(word.OrderBy(c => c));
                // Checks to see if it already contained in solutions.  If yes, adds to rejected.
                    if (solutions.Contains(sortedWord))
                    {
                        solutions.Remove(sortedWord);
                        rejected.Add(sortedWord);
                    }
                    // Otherwise adds word to solutions
                    else if (!rejected.Contains(sortedWord))
                    {
                        solutions.Add(sortedWord);
                    }
                }
                // Returns the number of unique words (minus one to account for the first row of numbers)
            return solutions.Count - 1;
        }
    }
}

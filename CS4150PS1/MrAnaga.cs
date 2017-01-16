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

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        public static void Main (string[] args)
        {
            MrAnaga m = new MrAnaga();
            m.AddWords();
        }

        /// <summary>
        /// Method that adds words from standard input into the dictionary Arraylist
        /// </summary>
        public void AddWords()
        {
            words = new ArrayList();
            string word = "";
            try
            {
                do
                {
                    word = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(word) == false && word.Length > 0)
                    {
                        if (word.Length > 1000)
                        {
                            throw new FormatException();
                        }

                        words.Add(word);
                    }
                    else
                    {
                        throw new ArgumentException(); 
                    }
                }
                while (word.Length > 0 && word != null);
            }
            catch (ArgumentException e1)
            {
                return;              
            }
            catch (FormatException e2)
            {
                return;
            }
            NotAnagrams(words);
        }
        /// <summary>
        /// Counts the number of words that are not anagrams of other words in the dictionary.
        /// </summary>
        /// <param name="w">Arraylist of words</param>
        /// <returns>The number of words that are not anagrams</returns>
        public string NotAnagrams(ArrayList w)
        {
            try
            {
                solutions = new HashSet<string>();
                rejected = new HashSet<string>();

                // If there are no words in the dictionary
                if (w.Count == 0)
                {
                    Console.WriteLine("0");
                    return "0";
                }

                foreach (string word in w)
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

                if (solutions.Count == 0)
                {
                    Console.WriteLine("0");
                    return "0";
                }
                int total = solutions.Count - 1;
                // Returns the number of unique words (minus one to account for the first row of numbers)
                Console.WriteLine(total.ToString());
                return total.ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}

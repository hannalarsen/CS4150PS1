using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace CS4150PS1
{
    class MrAnaga
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

        static void Main(string[] args)
        {
            

        }

        /// <summary>
        /// Adds words to the dictionary ArrayList
        /// </summary>
        /// <param name="word"></param>
        private void addWords(string word)
        {
            words = new ArrayList();
            words.Add(word);
        }
        /// <summary>
        /// Counts the number of words that are not anagrams of other words in the dictionary.
        /// </summary>
        /// <param name="d">A dictionary of words</param>
        /// <returns>The number of words that are not anagrams</returns>
        public int NotAnagrams(List<string> d)
        {
            foreach(string word in d)
            {
                sortedWord = String.Concat(word.OrderBy(c => c));
                if(solutions.Contains(sortedWord))
                {
                    solutions.Remove(sortedWord);
                    rejected.Add(sortedWord);
                }
                else if(!rejected.Contains(sortedWord))
                {
                    solutions.Add(sortedWord);
                }
            }
            return solutions.Count;
        }
    }
}

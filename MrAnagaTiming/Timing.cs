using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS4150PS1;
using System.Collections;

namespace MrAnagaTiming
{
    class Timing
    {
        public const int DURATION = 1000;
        

        static void Main(string[] args)
        {
            RunIt();
        }


        public static void RunIt()
        {
            int size = 50;
            double previousTime = 0;
            Console.WriteLine("\nSize\tTime (msec)\tDelta (msec)");
            for (int i = 0; i <= 10; i++)
            {
                size = size * 2;
                double currentTime = TimeIt(size);
                //Console.WriteLine("\nSize\tTime (msec)\tDelta (msec)");
                Console.Write((size) + "\t" + currentTime.ToString("G3"));
                if (i > 0)
                {
                    Console.WriteLine("   \t" + (currentTime - previousTime).ToString("G3"));
                }
                else
                {
                    Console.WriteLine();
                }
                previousTime = currentTime;
            }
        }
        public static double TimeIt(int k)
        {
            MrAnaga m = new MrAnaga(); 
            int n = 0;
            string letters = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[6];
            var random = new Random();
            ArrayList words = new ArrayList();
            // Generates words to put in dictionary
            while (n <= k)
            {
                for(int i = 0; i < 6; i++)
                {
                    stringChars[i] = letters[random.Next(letters.Length)];
                }
                string word = new string(stringChars);
                words.Add(word);
                n = n + 1;
            }

            // Create a stopwatch
            Stopwatch sw = new Stopwatch();

            // Keep increasing the number of repetitions until one second elapses.
            double elapsed = 0;
            long repetitions = 1;
            do
            {
                repetitions *= 2;
                sw.Restart();
                for (int i = 0; i < repetitions; i++)
                {
                    for (int d = 0; d < k; d++)
                    {
                        m.NotAnagrams(words);
                    }
                }
                sw.Stop();
                elapsed = msecs(sw);
            } while (elapsed < DURATION);
            double totalAverage = elapsed / repetitions / k;

            // Create a stopwatch
            sw = new Stopwatch();

            // Keep increasing the number of repetitions until one second elapses.
            elapsed = 0;
            repetitions = 1;
            do
            {
                repetitions *= 2;
                sw.Restart();
                for (int i = 0; i < repetitions; i++)
                {
                    for (int d = 0; d < k; d++)
                    {
                    }
                }
                sw.Stop();
                elapsed = msecs(sw);
            } while (elapsed < DURATION);
            double overheadAverage = elapsed / repetitions / k;

            // Return the difference
            return totalAverage - overheadAverage;

        }

        /// <summary>
        /// Returns the number of milliseconds that have elapsed on the Stopwatch.
        /// </summary>
        public static double msecs(Stopwatch sw)
        {
            return (((double)sw.ElapsedTicks) / Stopwatch.Frequency) * 1000;
        }
    }
}

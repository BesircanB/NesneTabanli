using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumledekiKelimeSayilari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Define the sentence
            string sentence = "Merhaba ahmet merhaba";

            // Step 2: Convert the sentence to lowercase and split it into words
            string[] words = sentence.ToLower().Split(' ');

            // Step 3: Create a Dictionary to store word counts
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Step 4: Count the occurrences of each word
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Step 5: Display the word counts
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"Word '{entry.Key}' appears {entry.Value} time(s)");
            }

            Console.ReadLine();


        }
    }
}

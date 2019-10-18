using System;
using System.Collections.Generic;
using System.IO;

namespace TextualAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ComputeWordFrequenciesFromFile("../../../Data/small.txt");
            var stopWords = GetStopWords("../../../Data/stop-word-list.txt");

        }


        public static Dictionary<string, int> ComputeWordFrequencies(string s, bool ignoreStopWords = false)
        {
            var wordCounts = new Dictionary<string, int>();

            // do all the work


            return wordCounts;
        }

        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            // open the file

            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = streamReader.ReadToEnd();

                Console.WriteLine(text);

                var words = text.Split(" \n.");

                foreach( string s in words)
                {
                    Console.WriteLine(s);
                }
            }

            // read file contents into a string


            var wordCounts = new Dictionary<string, int>();

            // do all the work


            return wordCounts;
        }

        public static List<string> GetStopWords(string path)
        {
            var stopWords = new List<string>();
            
            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = streamReader.ReadToEnd();

                var words = text.Split(" \n.");

                foreach (string s in words)
                {
                    Console.WriteLine(s);
                }
            }

            return stopWords;
        }


    }
}

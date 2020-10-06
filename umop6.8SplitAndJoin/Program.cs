using System;
using System.IO;

namespace umop6o8SplitAndJoin
{
    class Program
    {
        public static void Main(string[] args)
        {
            string citiesPopulation = File.ReadAllText("states.txt");
            Console.WriteLine(ReplaceIncorrectSeparators(citiesPopulation));
            Console.ReadKey();
        }
        public static string ReplaceIncorrectSeparators(string text)
        {
            string[] separatorStrings = { " ", ":", ": ", ";", ",", "-", " - ", "\t" };
            string[] words = text.Split(separatorStrings, System.StringSplitOptions.RemoveEmptyEntries);
            string wordsTab = String.Join("\t", words);
            return wordsTab;
        }
    }
}
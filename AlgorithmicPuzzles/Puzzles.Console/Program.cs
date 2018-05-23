namespace Puzzles.Console
{
    using System.Collections.Generic;
    using SomeAlgos;

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce a word to get all its permutations");

            var line = System.Console.ReadLine();
            System.Console.WriteLine();
            var result = new StringAlgorithms().AllPermutations(line);

            var index = 1;
            foreach (var word in result)
            {
                System.Console.WriteLine($"{index}. {word}");
                index += 1;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Please enter a list of words : ");

            System.Console.WriteLine();
            var listWords = new List<string>();
            var shouldContinue = true;
            while (shouldContinue)
            {
                System.Console.Write("More words yes(Y) or no(N) : ");
                var command = System.Console.ReadLine();
                switch (command)
                {
                    case "y":
                    case "Y":
                        System.Console.Write("Introduce a word : ");
                        var readLine = System.Console.ReadLine();
                        listWords.Add(readLine);
                        break;
                    case "n":
                    case "N":
                        shouldContinue = false;
                        break;
                    default:
                        System.Console.WriteLine("un-recognized command");
                        break;
                }
            }

            System.Console.WriteLine();
            foreach (var word in new StringAlgorithms().GetOnlyAnagrams(listWords))
            {
                System.Console.WriteLine(word);
            }

            System.Console.ReadLine();
        }
    }
}

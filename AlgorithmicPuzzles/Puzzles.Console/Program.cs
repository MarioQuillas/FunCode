using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puzzles.SomeAlgos;

namespace Puzzles.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine();
            var result = new StringAlgorithms().AllPermutations(line);

            foreach (var word in result)
            {
                System.Console.WriteLine(word);
            }

            System.Console.WriteLine();

            foreach (var word in new StringAlgorithms().GetOnlyAnagrams(new List<string>() { "123", "451", "1021", "321", "aim", "mia", "154", "toto" }))
            {
                System.Console.WriteLine(word);
            }

            System.Console.ReadLine();
        }
    }
}

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

            System.Console.ReadLine();
        }
    }
}

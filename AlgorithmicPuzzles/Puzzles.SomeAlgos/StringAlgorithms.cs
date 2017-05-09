using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Puzzles.SomeAlgos
{
    public class StringAlgorithms
    {
        public List<string> AllPermutations(string word)
        {
            return this.AllPermutations(word.ToList());
        }

        public List<string> AllPermutations(List<char> list)
        {
            if (list.Count == 0) return new List<string>(){""};

            var result = new List<string>();
            var length = list.Count;

            var pivotCharacter = list[0];
            var pivotList = new List<char>();

            for (var i = 1; i < length; ++i)
            {
                pivotList.Add(list[i]);
            }

            var pivotPermutations = this.AllPermutations(pivotList);

            for (var i = 0; i < length; ++i)
            {
                result.AddRange(pivotPermutations.Select(word => word.Insert(i, pivotCharacter.ToString())));
            }

            return result;
        }

        public bool AreAnagrams(string word1, string word2)
        {



            return false;
        }
    }
}

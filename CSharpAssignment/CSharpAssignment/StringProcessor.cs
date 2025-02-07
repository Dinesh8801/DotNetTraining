using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    internal class StringProcessor
    {
        public static string RemoveDuplicateCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}

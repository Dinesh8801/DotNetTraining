using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    internal class PalindromeChecker
    {
        public static bool IsPalindrome(string str)
        {
            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}

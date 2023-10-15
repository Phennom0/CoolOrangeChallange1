using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    { 
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return true;
            } else {
                if (s[0] == s[s.Length - 1])
                {
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                }else return false;
            }
        } 
    }
}

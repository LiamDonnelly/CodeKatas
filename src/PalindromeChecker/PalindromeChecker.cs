using System;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                char[] arrOfString = s.ToCharArray();

                Array.Reverse(arrOfString);
                
                if (!s.Equals(new string(arrOfString)))
                {
                    return false;
                }
            }

            return true;

            throw new NotImplementedException();
        }
    }
}

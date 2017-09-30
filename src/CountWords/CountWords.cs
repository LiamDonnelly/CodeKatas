using System;

namespace CountWords
{
    public class CountWords
    {
        public int Count(string s)
        {
            if(!String.IsNullOrEmpty(s))
            {
                string[] arrayOfString = s.Split(',');

                int count = arrayOfString.Length;
                return count;
            }

            return 0;
            
            throw new NotImplementedException();
        }
    }
}

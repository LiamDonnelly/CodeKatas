using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Check(int i)
        {
            string word = "";

            if((i % 3) == 0 )
            {
                word += "Fizz";
            }

            if(((i % 5) == 0))
            {
                word += "Buzz";
            }

            if(word.Equals(""))
            {
                word +=  i.ToString();
            }

            return word;

            throw new NotImplementedException();
        }
    }
}

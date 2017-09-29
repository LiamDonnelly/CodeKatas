using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseString
    {
        public string Reverse(string s)
        {
            char[] arrayOfString = s.ToArray();

            Array.Reverse(arrayOfString);
            
            return new string(arrayOfString);

            throw new NotImplementedException();
        }
    }
}

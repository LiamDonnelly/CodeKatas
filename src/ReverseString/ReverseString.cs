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

            /*
                Another method without the use of System Array library
                char[] newArray = new char[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    newArray[i] = arrayOfString[s.Length - 1 - i];
                }
                
                return new string(newArray);
            */
            
            throw new NotImplementedException();
        }
    }
}

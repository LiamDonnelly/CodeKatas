using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public int GetNextPrimeNumber(int i)
        {
            List<int> negativeNumbers = new List<int>();

            for (int j = i ; j > 1; j--)
            {
                if ((j % 2) == 0)
                {
                    continue;
                }
                else
                {
                    negativeNumbers.Add(j);
                }
            }

            bool isPrime = true;
            int n = i;
            
            for(; i < 2 * n; ++i)
            {
                if((i % 2) == 0)
                {
                    continue;
                }
                else
                {
                    foreach(int oddNum in negativeNumbers)
                    {
                        decimal result = i / oddNum;

                        if((result % 1 ) == 0 )
                        {

                            isPrime = false;
                        }
                    }

                    if(isPrime)
                    {
                        return i;
                    }
                }
            }
            return 0;
            throw new NotImplementedException();
        }
    }
}

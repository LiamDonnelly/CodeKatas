using System;

namespace PiCalculator
{
    public class PiCalculator
    {
        public string GetPi(int i)
        {
            int index = 2 + i;
            char[] pi = Math.PI.ToString().ToCharArray();

            Array.Resize(ref pi, index);

            return new string(pi);

            throw new NotImplementedException();
        }

        public int GetPiDigit(int i)
        {
            int piDigit = 0;
            int index = 1 + i;

            char[] pi = Math.PI.ToString().ToCharArray();

            bool a = Int32.TryParse(pi[index].ToString(), out piDigit);

            return piDigit;

            throw new NotImplementedException();
        }
    }
}

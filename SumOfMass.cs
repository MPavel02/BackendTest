using System;

namespace SumOfTwoSmallest
{
    public class SumOfMass
    {
        public double SumOfSmallest(double[] numbs, int countofnumbers)
        {
            double sum = 0;

            if (numbs == null)
            {
                throw new ArgumentNullException("Null mass");
            }
            if (numbs.Length == 0)
            {
                throw new ArgumentNullException("0 elements in mass");
            }
            if (countofnumbers > numbs.Length)
            {
                throw new IndexOutOfRangeException("Bigger than count of elems in mass");
            }
            else
            {
                Array.Sort(numbs);

                for(int i = 0; i < countofnumbers; i++)
                {
                    sum = sum + numbs[i];
                }
            }

            return sum;
        }
    }
}

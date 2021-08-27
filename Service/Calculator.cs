using System;
using System.Linq;

namespace Service
{
    public class Calculator : ICalculator
    {
        public int SumOfEvenTerms(int range)
        {
            if (range > 4000)
            {
                throw new ArgumentOutOfRangeException(message: "Range must be less than 4000",null);
            }
            var sum = 1;
            var x = 1;
            var y = 2;
            int z;

            while ((z = x + y) < range){
                x = y;
                y = z;

                if (z % 2 != 0 )
                {
                    sum += z;
                }
            }

            return sum;

        }
    }
}

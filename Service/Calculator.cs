using System;
using System.Linq;

namespace Service
{
    public class Calculator : ICalculator
    {
        public int SumOfEvenTerms(int range)
        {
            if (range > 4000000)
            {
                throw new ArgumentOutOfRangeException(message: "Range can not be bigger than 4M",null); 
            }
            var sum = 2;
            var x = 1;
            var y = 2;
            int z;

            while ((z = x + y) < range){
                x = y;
                y = z;

                if (z % 2 == 0 )
                {
                    sum += z;
                }
            }

            return sum;

        }
    }
}

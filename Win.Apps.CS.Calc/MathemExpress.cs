using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win.Apps.CS.Calc
{
    class MathemExpress
    {
        public static double Factorial(double f)
        {           
            bool test = f >= 0;
            double Factorial = 1;

            if (test)
            {
                if (f == 0)
                    return Factorial;
                else
                {
                    for (double i = Factorial; i <= f; i++)
                    {
                        Factorial = Factorial * i;
                    }
                    return Factorial;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}


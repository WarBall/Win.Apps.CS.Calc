﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win.Apps.CS.Calc
{
    class MathemExpress
    {
        #region Const
        private const byte regresNum = 1;
        private const byte squareNum = 2;
        #endregion

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

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division (double a, double b)
        {
            return a / b;
        }

        //Метод обратного числа
        public static double RegresNum(double a)
        {
            return regresNum / a;
        }

        //Метод кубического корня
        public static double CubicRoot(double number)
        {
            double regNum = RegresNum(3);

            double opResult = Math.Pow(number, regNum);

            return opResult;
        }

        public static double SquareNumber(double number)
        {
            double result = Math.Pow(number, squareNum);

            return result;
        }
    }
}


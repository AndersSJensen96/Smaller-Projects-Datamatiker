using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
    {
    class calculator
        {
            public static double Add(double nr1, double nr2)
                {
                double total = nr1 + nr2;
                Console.WriteLine("test");

                return total;
                }
            public static double Subtract(double nr1, double nr2)
                {
                return nr1 - nr2;
                }
            public static double Multiply(double nr1, double nr2)
                {
                return nr1 * nr2;
                }
            public static double Divide(double nr1, double nr2)
                {
                return nr1 / nr2;
                }
        }
    }

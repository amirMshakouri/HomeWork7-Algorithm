using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7_Algorithm
{
   
    
        internal class GcdCalculator
        {
            public static int FindGcd(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                return a;
            }
        }
    
}

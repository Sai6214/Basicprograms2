using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class MonthlyPayment
    {


        //E = (P.r.(1+r)n) / ((1+r)n – 1) 
        static float emi_calculator(float p, float r, float t)
        {
            float emi;

            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            emi = (p * r * (float)Math.Pow(1 + r, t))
                   / (float)(Math.Pow(1 + r, t) - 1);

            return (emi);

        }

        static public void Main()
        {
            float principal, rate, time, emi;
            principal = 10000;
            rate = 10;
            time = 2;

            emi = emi_calculator(principal, rate, time);

            Console.WriteLine("Monthly EMI is = " + emi);
            Console.ReadLine();
        }
    }
}
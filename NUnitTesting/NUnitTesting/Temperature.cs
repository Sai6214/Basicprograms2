using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class Temperature
    {
        //Conversion of Celicus to Fahrenheit
        static void Cel_To_Fah(double n)
        {
            double CtoF = ((n * 9.0f / 5.0f) + 32.0f);
            Console.WriteLine($"After Conversion of Celicus to Fahrenheit : {CtoF}");
        }

        //Conversion of Fahrenheit to Celicus
        static void Fah_To_Cel(double n)
        {
            double FtoC = (n - 32.0f) * 5.0f / 9.0f;
            Console.WriteLine($"After Conversion of Fahrenheit to Celicus : {FtoC}");
        }


        //public static void Main()
        //{
        //    Console.WriteLine("Enter the temperature to conversion Celicus to Fahrenheit and its Viseversa :  ");
        //    double temp = Convert.ToDouble(Console.ReadLine());
        //    Cel_To_Fah(temp);
        //    Fah_To_Cel(temp);
        //    Console.ReadLine();

        //}
    }
}
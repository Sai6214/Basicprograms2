using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class DayOfWeek
    {
        public void dayofweek(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5,
                            1, 4, 6, 2, 4 };
            y -= (m < 3) ? 1 : 0;

            int date = (y + y / 4 - y / 100 + y / 400
                             + t[m - 1] + d) % 7;

            Console.Write($"the Day of Week  :- {date}  :    ");
            switch (date)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            DayOfWeek d = new DayOfWeek();
            Console.WriteLine("Enter the date dd-mm-yy formate ");
            Console.Write("Enter Day :  ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month :  ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year :  ");
            int year = Convert.ToInt32(Console.ReadLine());
            d.dayofweek(day, month, year);

        }

    }
}
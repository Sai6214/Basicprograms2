using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class MoneyChange
    {
        public static void countCurrency(int amount)
        {
            Console.WriteLine($"The amount is {amount}");
            Console.WriteLine("-----------------------\n");
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[8];
            int toalNoteRequired = 0;
            for (int i = 0; i < 8; i++)
            {
                int l = notes[i];
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    toalNoteRequired = toalNoteRequired + noteCounter[i];
                    amount = amount - notes[i] * noteCounter[i];
                }

            }

            //print the count the notes required
            Console.WriteLine($"The total count of Money is {toalNoteRequired} ");
            Console.WriteLine("-----------------------\n");


            //print the money
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"The money is {notes[i]} and the pieces requied --- {noteCounter[i]}");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Enter money to get change   
            Console.Write("Enter the Money for change :  ");
            int amount = Convert.ToInt32(Console.ReadLine());
            countCurrency(amount);

        }
    }
}
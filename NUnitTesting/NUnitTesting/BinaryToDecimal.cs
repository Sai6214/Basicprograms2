using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class BinaryToDecimal
    {
        public static int binaryToDecimal(int n)
        {
            int num = n;
            int dec_value = 0;

            int base1 = 1;

            int temp = num;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp = temp / 10;

                dec_value += last_digit * base1;

                base1 = base1 * 2;
            }

            return dec_value;
        }

        public static void Main()
        {
            int num = 10101001;

            System.Console.Write(binaryToDecimal(num));
            Console.ReadLine();
        }
    }
}
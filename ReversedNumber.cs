using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingDigits
{
    class ReversedNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(number));

        }

        public static int Reverse(int n)
        {
            int r, reversedNumber=0;
            while (n != 0)
            {
                r = n % 10;
                reversedNumber = reversedNumber * 10 + r;
                n /= 10;
            }

            return reversedNumber;
        }
    }
}

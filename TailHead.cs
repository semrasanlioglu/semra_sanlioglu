using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossing
{
    class TailHead
    {
        public static void Main(string[] args)
        {
            int choice;
            int countTail = 0;
            int countHead = 0;
            do
            {
                Console.WriteLine("Enter 1 for Toss Coin, 2 for Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (Flip())
                {
                    Console.WriteLine("TAIL");
                    countTail++;
                }

                else
                {
                    Console.WriteLine("HEAD");
                    countHead++;
                }
            } while (choice != 2);

            Console.WriteLine("Number of Tails : " + countTail);
            Console.WriteLine("Number of Heads : " + countHead);
        }
        public static bool Flip()
        {
            Random randomNumber = new Random();
            int flip;

            flip = randomNumber.Next(1, 3);

            if (flip == 1)
                return true;
            else
                return false;
        }
    }
}

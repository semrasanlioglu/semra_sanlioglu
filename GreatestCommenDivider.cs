using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class GreatestCommenDivider
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("GCD : "+ Greatestcommondivisor(num1, num2));
        }

        public static int Greatestcommondivisor(int a, int b)
        {
            if (b != 0)
                return Greatestcommondivisor(b, a % b);
            return a;
        }
    }
}

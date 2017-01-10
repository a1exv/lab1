using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter digit: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            int digit2 = 0;
            if (digit > 0)
            {
                while (digit > 0)
                {
                    if (digit2 == 0)
                    {
                        digit2 = digit % 10;
                        digit = digit / 10;
                    }
                    else
                    {
                        digit2 = digit2 * 10 + digit % 10;
                        digit = digit / 10;
                    }
                }
                Console.WriteLine("final digit is {0}", digit2);
            }
            else Console.WriteLine("it must be positive value!");
        }
    }
}

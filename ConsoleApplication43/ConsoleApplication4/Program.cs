using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite a i b:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                while (b <= a)
                {
                    for (int i = 0; i < b; i++)
                    {
                        Console.Write(b);
                    }
                    Console.Write('\n');
                    b++;
                }
            }
            else Console.WriteLine("a dolzhno byt\' bol\'she b!");
        }
    }
}

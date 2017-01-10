using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite 6-znachnii nomer bileta: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumFirstHalf=0, sumSecondHalf=0;
            int count = 6;
            while (number != 0)
            {
                if (count > 3)
                {
                    sumFirstHalf += number % 10;
                    number = number / 10;
                    count--;
                }
                else
                {
                    sumSecondHalf += number % 10;
                    number = number / 10;
                    count--;
                }
            }
            if (count == 0)
            {
                if (sumSecondHalf == sumFirstHalf)
                {
                    Console.WriteLine("LUCK!");
                }
                else Console.WriteLine("UNLUCK!");
            }
            else Console.WriteLine("6-znachnoe!!");
        }
    }
}

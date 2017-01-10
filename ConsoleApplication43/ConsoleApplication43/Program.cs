using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Char a;
            while(true){
                a = Convert.ToChar(Console.Read());
                if (a == ' ')
                {
                    count++;
                }
                if (a == '.') break;

            }
            Console.WriteLine("Kol-vo probelov: {0}", count);
        }
    }
}

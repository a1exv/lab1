using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite stroku");
            string str = Console.ReadLine();
            int tmpdig;
            Char tmp;
            Char []str2 = new Char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                tmp = str[i];
                tmpdig = Convert.ToInt32(tmp);
                if (tmpdig < 126 && tmpdig > 96)
                {
                    tmpdig = tmpdig - 32;
                    tmp = Convert.ToChar(tmpdig);
                }
                else if (tmpdig > 64 && tmpdig < 92)
                {
                    tmpdig = tmpdig + 32;
                    tmp = Convert.ToChar(tmpdig);
                }
                str2[i] = tmp;
            }

            Console.WriteLine(str2);
        }
    }
}

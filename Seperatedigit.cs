using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Seperatedigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeperateDigit(123));
        }

        private static string SeperateDigit(int num)
        {
            string str = "";
            while(num>0)
            {
                str = str + num % 10 + "\n";
                num = num / 10;
            }

            return str;
        }
    }
}

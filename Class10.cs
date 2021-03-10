using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class10
    {

        public static string SeparateDigit(int num)
        {

            string str = string.Empty;
            while (num != 0)
            {
                str = str + num % 10 + ",";
                num /= 10;
            }
            return str.Substring(0, str.Length - 1) + ".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SeparateDigit(123));
        }
    }
}
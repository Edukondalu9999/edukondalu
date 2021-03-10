using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RevNum
    {
        public static int Revnum(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;

            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Revnum(123));
        }

    }
}
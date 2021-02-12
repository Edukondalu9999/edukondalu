using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Iseven
    {
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }
            return rev;
        }
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsEven(2));
            Console.WriteLine(IsEven(5));
        }
    }
}

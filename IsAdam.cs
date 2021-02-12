using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Isadam
    {
        public static bool IsAdam(int num)
        {
            return Square(num) == Reverse(Square(Reverse(num)));
        }
        public static int Reverse(int num)
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
        public static int Square(int num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAdam(12));
            Console.WriteLine(IsAdam(10));

        }
    }
}


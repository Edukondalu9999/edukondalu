using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class IsPalin
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
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(123));
        }
    }
}

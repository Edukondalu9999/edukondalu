using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IsPalindrome
    {
        public static bool palindrome(int num)
        {
            int rev = 0;
            int copy = num;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;

            }
            return copy==rev;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome(121));
        }

    }
}

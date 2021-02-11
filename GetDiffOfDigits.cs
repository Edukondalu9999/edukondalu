using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class GetDiffOfDigits
    {

        public static int GetDiffOfDigit(int num)
        {
            if (num > 99)
            {
                return -2;
            }
            if (num < 0)
            {
                return -3;
            }
            if (num >= 0 && num <= 9)
            {
                return -1;
            }
            return num / 10 - num % 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetDiffOfDigit(38));
            Console.WriteLine(GetDiffOfDigit(-4));
            Console.WriteLine(GetDiffOfDigit(100));
        }
    }
}

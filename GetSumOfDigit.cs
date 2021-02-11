using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class GetSumOfDigit
    {

        public static int GetSumOfDigits(int num)
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
            return num%10+num/10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumOfDigits(34));
            Console.WriteLine(GetSumOfDigits(-1));
            Console.WriteLine(GetSumOfDigits(100));
        }
    }
}

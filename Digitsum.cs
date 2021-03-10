using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Digitsum
    {
        public static int DigitSum(int num)
        {
            int sum = 0;


            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num/10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DigitSum(123456));
        }
    }
}
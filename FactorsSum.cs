using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FactorsSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorssum(4));
        }
        public static int factorssum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
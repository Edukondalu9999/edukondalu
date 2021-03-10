using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factorscount
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorscount(4));
        }
        public static int factorscount(int num)
        {
            int count = 0;
            
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

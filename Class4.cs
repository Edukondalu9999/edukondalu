using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main(string[] args)
        {
            int num = 145;
           
            int sum = 0;
            int copy = num;
            while (num != 0)
            {
                int digit = num % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {

                    fact = fact * i;
                }
                sum = sum + fact;//24+120+1=145
                num = num / 10;
              
            }
            if (copy == sum)
            {
                Console.WriteLine("It is strong a number");
            }
            else
            {
                Console.WriteLine("It is not strong a number");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Strongnum
    {
        static void Main(string[] args)
        {
            int num = 135;
            int copy = num;
            int sum = 0;
            while (num > 0)//145>0 14>0 1>0 0>0
            {
                int digit = num % 10;// digit = 5 digit = 4 digit = 1
                int start = 1;
                int fact = 1;
                while (start <= digit)//1<=5 2<=5 3<=5 4<=5 5<=5 6<=5
                {
                    fact = fact * start;//fact = 120
                    start++;//6
                }
                sum = sum + fact;// sum = 145
                num = num / 10;// num = 14 num = 1 num = 0
            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} is Strong number");
            }
            else
            {
                Console.WriteLine($"{copy} is not strong number");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Maxnum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (max < digit)
                {
                    max = digit;

                }
                num = num / 10;
            }
            Console.WriteLine(max);
        }
    }
}

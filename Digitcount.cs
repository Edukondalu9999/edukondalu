using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Digitcount
    {
        static void Main(string[] args)
        {

            int num = 67895;
            int count = 0;
            while (num != 0)

            {
                int digit = num % 10;
                count++;
                num = num / 10;

            }
            Console.WriteLine($"Digit count is {count}");
        }
    }
}

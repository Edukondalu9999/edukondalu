using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Sod { 
     static void Main(string[] args)
    {
        int num = 546;
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }
        Console.WriteLine("Sum of the digits :{0}", sum);
    }
}
}
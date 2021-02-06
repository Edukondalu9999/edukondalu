using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class AriOper
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number1 : ");
            int num1 = int.Parse(Console.ReadLine());//5
            Console.Write("Enter  number1 : ");
            int num2 = int.Parse(Console.ReadLine());//2
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2);
        }
    }

}
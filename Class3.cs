using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(string[] args)
        {
            int num = 3421;
            int max = num % 10;
            while(num!=0)
            {
                int digit = num % 10;
                if(max<digit)
                {
                    max = digit;
                }
                num = num / 10;
            }
            Console.WriteLine(max);      
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Digitcount
    { 
    public static int DigitCount(int num)
    {
        int count = 0;


        while (num != 0)
        {
            int digit = num % 10;
            count++;
            num /= 10;
        }
        return count;
    }
    static void Main(string[] args)
    {
            Console.WriteLine(DigitCount(123456)); 
    }
}
}
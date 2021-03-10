using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Digitavg
    {
        public static double DigitAvg(int num)
        {
            int count = 0;
            int sum = 0;
           

            while (num != 0)
            {
                int digit = num % 10;
                count++;
                sum = sum + digit;
                num = num / 10;
            }
            double avg = sum / count;
            return avg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DigitAvg(123));
        }
    }
}

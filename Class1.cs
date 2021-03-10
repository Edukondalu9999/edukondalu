using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 121;
            int count = 0;
            int sum = 0;
            int rev = 0;
            int copy = num;
            while(num>0)
            {
                int digit = num % 10;
                num = num / 10;
                count++;
                sum = sum + digit;
                rev = rev * 10 + digit;
                Console.WriteLine(digit);
            }
            double avg = sum / count;
            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine(rev);

            if(copy==rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
            
        }
    }
}

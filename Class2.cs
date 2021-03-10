using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            int num = 6;
            int count = 0;
            int sum = 0;
            int copy = num;
            
            for(int i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    count++;
                    sum = sum + i;
                }
                 
            }
            double avg = sum / count;
            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            if(count==2)
            {
                Console.WriteLine("It is a prime");
            }
            else
            {
                Console.WriteLine("It is not a prime");
            }
            int per = sum - num;
            if(copy==per)
            {
                Console.WriteLine("It is perfct");
            }
            else
            {
                Console.WriteLine("It is not perfect");
            }

            
        }
    }
}

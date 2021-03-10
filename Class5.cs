using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class5
    {
        static void Main(string[] args)
        {
            int num = 153;
            int sum = 0;
            int copy = num;
            int count = 0;
            while(num>0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }
            num = copy;
            while(copy>0)
            {
                int poval = 1;
                int digit = copy % 10;
                for(int i=1;i<=count;i++)
                {
                    poval = poval * digit;
                   
                }
                
                copy /= 10;
                sum = sum + poval;
            }
            if(sum==num)
            {
                Console.WriteLine("amstrong");
            }
            else
            {
                Console.WriteLine("not aamstrong");
            }
        }
    }
}

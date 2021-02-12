using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class IsPerfect
    {
        public static int Perfect(int num)
        {

            int sum = 0;
            int copy = num;
            while (num > 0)
            {
                int a = num % 10;
                sum = sum + a;
                num /= 10;
            }
            return sum;
        }
        public static bool Isperfect(int num)
        {
            return num == Perfect(num);
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Isperfect(6));

            Console.WriteLine(Isperfect(33));

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class EnumsExamples
    {
        enum days { sunday, monday = 111, tuesday, wedesday, thursday, friday, saturday };
        static void Main(string[] args)
        {

            Console.WriteLine($"{days.sunday}=>{(int)days.sunday}");
            Console.WriteLine($"{days.monday}=>{(int)days.monday}");
            Console.WriteLine($"{days.tuesday}=>{(int)days.tuesday}");
            Console.WriteLine($"{days.wedesday}=>{(int)days.wedesday}");


        }
    }
}

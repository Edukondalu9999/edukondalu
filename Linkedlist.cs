using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class Linkedlist
    {
        static void Main(string[] args)
        {
            LinkedList<object> Abhiram = new LinkedList<object>();
            Abhiram.AddLast("Vamshi");
            Abhiram.AddLast("Mani");
            Abhiram.AddLast("Harish");
            Abhiram.AddLast("Bhuvana");
            Abhiram.AddLast("Greeshma");
            Abhiram.AddLast("Vamshi");
            Abhiram.AddLast("mani");

            Abhiram.AddLast('S');
            Abhiram.AddLast('B');
            Abhiram.AddLast(200);
            Abhiram.AddLast(100);
            Abhiram.AddLast(200);

            foreach (object ob in Abhiram)
            {
                Console.WriteLine(ob);
            }




        }
    }
}

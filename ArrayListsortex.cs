using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet
{
    class ArrayListsortex
    {
        static void Main(string[] args)
        {
            ArrayList nameslist = new ArrayList();
            nameslist.Add("Edukondalu");
            nameslist.Add("Laxmammma");
            nameslist.Add("Ramalu");
            foreach (string s in nameslist)
            {
                Console.WriteLine(s);
            }
            nameslist.Sort();
            nameslist.Reverse();
            foreach (string s in nameslist)
            {
                Console.WriteLine(s);

            }
        }
    }
}


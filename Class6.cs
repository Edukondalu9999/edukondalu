using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class6
    {
        public int id;
        public String name;
        public float salary;
        public Class6(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Class6 e1 = new Class6(101, "Abhiram", 890000f);
            Class6 e2 = new Class6(102, "Edukondalu", 490000f);
            e1.display();
            e2.display();

        }
    }
}
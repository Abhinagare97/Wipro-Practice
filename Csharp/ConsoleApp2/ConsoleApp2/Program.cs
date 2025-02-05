using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public string name;
        static void Main(string[] args)
        {
            int a = 10;

            int b = 20;
            Console.WriteLine($"{a}, {b}");

            Program p = new Program();
            p.name = "C Sharp";
            Program pp = p;
            pp.name="Java";
            Console.WriteLine(p.name);

        }
    }
}

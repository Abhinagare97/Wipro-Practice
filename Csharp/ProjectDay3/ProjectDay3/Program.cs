using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectDay3
{

    public class Person
    {
        public virtual void jd()
        {
            Console.WriteLine("all work");

        }
    }
   
    public class Employee : Person
    {
        public override void jd()
        {
            Console.WriteLine("Does Company work");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Employee();
            p.jd();

            Test t = new Test();
            Test t1 = new Test(20, 30);
        }
    }
}

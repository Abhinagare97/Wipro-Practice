using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int id=100;
        public void display()
        {
            Console.WriteLine(id);
        }

        public Class1()
        {

        }

    }
    public class Class2 : Class1
    {
        public void display()
        {
           //Console.WriteLine(id);
        }
    }

}

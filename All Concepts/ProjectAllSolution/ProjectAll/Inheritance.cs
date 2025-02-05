using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAll
{
   
        public class Parent
        {
            string name = "Parent";

            public virtual void printName()
            {
                Console.WriteLine("Name is " + name);
            }
        }
        public class Child : Parent {
            string name = "Child";
            public override void printName()
            {
                Console.WriteLine("Name is " + name);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionss
{

    public class Employee {
        public string name { get; set; }
        public string address { get; set; }
        public int number { get; set; }

        public Employee(string name, string address, int number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }

        public Employee()
        {
        }

        

        public void PrintData()
        {
            Console.WriteLine("this is the employee info");
        }
    }

    internal class Program
    {
       
        public static void GetMethods(Type type)
        {
            MethodInfo[] methodInfo = type.GetMethods();
            foreach(MethodInfo m in methodInfo)
            {
                Console.WriteLine($"Name: {m.Name}, Type: {m.ReturnType}");
            }



        }

        static void Main(string[] args)
        {
            int a = 23;
            Type type = a.GetType();
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Type typee = Type.GetType("Reflectionss.Employee");
            Program.GetMethods(typee);

           
        }


        
    }
}

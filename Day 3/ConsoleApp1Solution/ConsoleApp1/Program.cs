using System;
using ClassLibrary1;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleClass c = new ConsoleClass();
            c.display(); 
        }
    }

    public class ConsoleClass : Class1
    {
        //Console.WriteLine("sd");
        public void display()
        {
            Console.WriteLine("id of class1 is: "+ id);
        }
    }

}
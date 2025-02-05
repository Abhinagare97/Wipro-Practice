using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    internal class Program
    {

        public delegate void GetDone();
        public static void Add(int a, int b)
        {
            Console.Write("adddition");

        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtract");
        }










        public delegate void PrintDelegate();

        public delegate void YourAge();
        public static void printdata()
        {
            Console.WriteLine("Print method called");
        }

        public static void AgeData()
        {
            Console.WriteLine("Age method called.");
        }


        static void Main(string[] args)
        {
            PrintDelegate pd = new PrintDelegate(printdata);
            pd();
            YourAge age = new YourAge(AgeData);
            age();


            GetDone gt = new GetDone(Add);
            gt += new GetDone(Sub);
           gt(1, 3);
            



        }
    }
}


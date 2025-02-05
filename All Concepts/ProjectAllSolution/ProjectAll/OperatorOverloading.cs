using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAll
{
    internal class OperatorOverloading
    {

    }
    class Distance
    {
        public int Kilometers;

        public Distance(int km)
        {

            Kilometers = km;

        }

        public static Distance operator +(Distance a, Distance b)
        {

            return new Distance(a.Kilometers + b.Kilometers);
        }

        public void result()
        {
            Console.WriteLine($"The total distance : {Kilometers}");

        }

    }
    class Area
    {
        public int length;
        public Area(int length)
        {
            this.length = length;
        }
        public static Area operator +(Area a, Area b)
        {

            return new Area(a.length + b.length);
           
        }
        public void result()
        {
            Console.WriteLine($"The total distance : {length}");

        }



        //class Program
        //{
        //    public static void Main(string[] args)
        //    {



        //        Distance d1 = new Distance(10);
        //        Distance d2 = new Distance(20);
        //        Distance totalDistance = d1 + d2;

        //        totalDistance.result();


        //    }
        //}

    }
}
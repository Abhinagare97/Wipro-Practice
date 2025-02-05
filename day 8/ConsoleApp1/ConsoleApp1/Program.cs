using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AddMetaDataAttribute : Attribute
    {
        string msg { get; set; }
        public AddMetaDataAttribute(string Msg)
        {
            msg = Msg;
        }

    }
    public class Program
    {
        [Obsolete]
        void Add()
        {
            Console.WriteLine("Hii");
        }

        [AddMetaData("This is the Message ")]
        void Sub()
        {

        }
        static void Main(string[] args)
        {

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedExtensionM
{
    public static class NewService
    {
        public static void Test2(this OldService ser )
        {
            Console.WriteLine("This is test 2");
        }

        public static void NoOfWords(this OldService ser, string sentence)
        {
            string[] arr = sentence.Split(' ');
            Console.WriteLine("Array count: " + arr.Length);

        }
    }
}

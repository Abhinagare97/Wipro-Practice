using System;
namespace Encapsulation
{
    public class Voting {
        private int Age;
        public int age{
            set { Age= value; }
            get { return Age; }
      
    }
    }

    public class Encapsualtion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Voting v = new Voting();
            v.age = a;
            Console.WriteLine("The age is: " + v.age);
            
          

        }
    }
}

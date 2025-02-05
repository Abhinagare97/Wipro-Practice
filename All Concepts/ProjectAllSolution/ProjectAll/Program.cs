using System;
namespace ProjectAll { 
public class SolutionGiver
    {
        public static void Main(string[] args)
        {

            Parent p = new Parent();
            p.printName();


            Parent pp = new Child();
            pp.printName();

            //Child c = (Child) new Parent();
            //c.printName();

            Area a = new Area(10);
            Area b = new Area(20);

            Area c = a + b;
            Console.WriteLine("C is" + c);
            c.result();
            
        }
    }
}

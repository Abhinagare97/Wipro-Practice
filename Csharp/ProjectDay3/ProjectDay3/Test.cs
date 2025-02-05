using System;

namespace ProjectDay3
{
    class Test

    {
        int i, a;
        string s;
        bool b;

        //No args based constructor
        public Test()
        {
            Console.WriteLine("Constructor defined Explicitly");
            Console.WriteLine(i);

        }
        // args based constructor
        public Test(int a, int b)
        {
            Console.WriteLine("Constructor defined Explicitly");

            this.a = a;
            Console.WriteLine($"The value of a local variable : {a} ");
            Console.WriteLine(this.a); //this keyword resolves the ambiguity between the instance variable and local variable
        }

    }
}
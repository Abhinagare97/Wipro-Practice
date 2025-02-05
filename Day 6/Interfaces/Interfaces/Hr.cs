using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{ 
    class ContractualEmployee : PersonalDetails, iSalaryDetails
    {
        public void LastDrawn()
        {
            Console.WriteLine("Last drawn of contractual");
        }

    }
    class PermanentEmployee : PersonalDetails, iSalaryDetails
    {
        public void LastDrawn()
        {
            Console.WriteLine("Last drawn of permanent.");
        }
    }
    internal class Hr
    {
        public static void Main(string[] args)
        {
            ContractualEmployee c = new ContractualEmployee();
            Console.WriteLine("ContractualEmployee");
            c.LastDrawn();
            //personal details
            c.SetPanDetails("Pancon");
            Console.WriteLine(c.GetPanDetails());
            Console.WriteLine("*************************");


            PermanentEmployee p = new PermanentEmployee();
            Console.WriteLine("Permanent Employee.");
            p.LastDrawn();
            p.SetPanDetails("PanPer");
            Console.WriteLine(p.GetPanDetails());


        }
    }
}

using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionH
{
    public class AgeNotAllowed : Exception
    {
        public override string Message
        {
             get
            {
                return "You are not allowed!...";
            }
        }
        public override string HelpLink
        {
            get
            {
                return "\fsd\\dsf\this is link";
            }

        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the No under 299");
                int no = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new AgeNotAllowed();
                }
                if(no> 299)
                {
                    throw new InvalidNoExc();
                }

                
            }
            catch(AgeNotAllowed a)
            {
                Console.WriteLine(a.Message);
                Console.WriteLine(a.HelpLink);


            }
            catch (InvalidNoExc i)
            {
                Console.WriteLine("Invalid no entered.");
             //   Console.WriteLine(i.StackTrace);
            }
        }
    }
}
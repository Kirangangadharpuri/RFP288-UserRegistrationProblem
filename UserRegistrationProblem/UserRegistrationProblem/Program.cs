using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Validation validation = new Validation();
                Console.WriteLine("1- VALIDATE FIRST NAME");
                Console.WriteLine("2- VALIDATE LAST NAME");
                Console.WriteLine("3- VALIDATE EMAIL ID");
                Console.WriteLine("4-VALIDATE MOBILE NUMBER");
                Console.WriteLine("CHOOOSE ANY ABOVE OPTION");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        validation.Valid_FirstName();
                        break;
                    case 2:
                        validation.Valid_LastName(); 
                        break;
                    case 3:
                        validation.Valid_Email();
                        break;
                        case 4:
                        validation.Valid_MobilNumbere();
                        break;
                }
            }
        }
    }
}

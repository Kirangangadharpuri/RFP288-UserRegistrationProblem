using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public void Valid_FirstName()
        {
            Console.WriteLine("Enter first name ");
            string name = Console.ReadLine();
            string firstName = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("FIRST NAME IS VALID");
            }
            else
            {
                Console.WriteLine("INVALID FIRST NAME");
            }
        }
    }
}

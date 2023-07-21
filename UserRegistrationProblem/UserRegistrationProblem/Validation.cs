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
        public void Valid_LastName()
        {
            Console.WriteLine("Enter last name ");
            string name = Console.ReadLine();
            string lastName = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("LAST NAME IS VALID");
            }
            else
            {
                Console.WriteLine("INVALID LAST NAME");
            }
        }
        public void Valid_Email()
        {
            Console.WriteLine("Enter email id ");
            string emailId = Console.ReadLine();
            string email = "^[A-Za-z0-9]+@[a-z]+[.][a-z]?";
            if (Regex.IsMatch(emailId, email))
            {
                Console.WriteLine("EMAIL ID IS VALID");
            }
            else
            {
                Console.WriteLine("INVALIDE EMAIL ID NUMBER ");
            }
        }
        public void Valid_MobilNumbere()
        {
            Console.WriteLine("Enter mobile number ");
            string number = Console.ReadLine();
            string mobileNumber = "^[0-9]{2,3}[ ][7-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, mobileNumber))
            {
                Console.WriteLine("MOBILE NUMBER IS VALID");
            }
            else
            {
                Console.WriteLine("INVALID MOBILE NUMBER");
            }
        }
    }
}

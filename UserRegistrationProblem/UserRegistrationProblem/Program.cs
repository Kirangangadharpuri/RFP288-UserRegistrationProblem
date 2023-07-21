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
                Console.WriteLine("CHOOOSE ANY ABOVE OPTION");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        validation.Valid_FirstName();
                        break;
                }
            }
        }
    }
}

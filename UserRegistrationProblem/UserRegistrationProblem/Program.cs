using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Ankush");
            Console.WriteLine("--------------------------------------");
            validateUser.validateLastName("Bahekar");
            Console.WriteLine("--------------------------------------");
            validateUser.validateEmailId("ankushmb9@gmail.com");
            Console.WriteLine("---------------------------------------");
            validateUser.validateMobileNumber("9665082893");
            Console.ReadKey();
        }
    }
}
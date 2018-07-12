using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public abstract class UserInterface
    {
         public UserInterface()
        {

        }

         public static void GetContestantInfo(Contestant contestant, int RegistrationNumber)
        {
    
            var person1 = new Contestant();
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            person1.ContestantFirstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the contestant's last name.");
            person1.ContestantLastName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a valid email address.");
            person1.Email = Console.ReadLine().ToLower();
            Console.WriteLine($"Contestant One's user information: {person1.ContestantFirstName}, {person1.ContestantLastName}, {person1.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();

            var person2 = new Contestant();
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            person2.ContestantFirstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the contestant's last name.");
            person2.ContestantLastName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a valid email address.");
            person2.Email = Console.ReadLine().ToLower();
            Console.WriteLine($"Contestant Two's user information: {person2.ContestantFirstName}, {person2.ContestantLastName}, {person2.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();

            var person3 = new Contestant();
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            person3.ContestantFirstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the contestant's last name.");
            person3.ContestantLastName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a valid email address.");
            person3.Email = Console.ReadLine().ToLower();
            Console.WriteLine($"Contestant Three's user information: {person3.ContestantFirstName}, {person3.ContestantLastName}, {person3.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();

            var person4 = new Contestant();
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            person4.ContestantFirstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the contestant's last name.");
            person4.ContestantLastName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a valid email address.");
            person4.Email = Console.ReadLine().ToLower();
            Console.WriteLine($"Contestant Fours's user information: {person4.ContestantFirstName}, {person4.ContestantLastName}, {person4.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();

            var person5 = new Contestant();
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            person5.ContestantFirstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the contestant's last name.");
            person5.ContestantLastName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a valid email address.");
            person5.Email = Console.ReadLine();
            Console.WriteLine($"Contestant Five's user information: {person5.ContestantFirstName}, {person5.ContestantLastName}, {person5.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();
        }

        public static void SweepStakesName()
        {
            var name = new Sweepstakes("Very Lame Name");
            
        }

    }
}

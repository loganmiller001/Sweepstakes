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

         public void GetContestantInfo(Contestant contestant)
        {
            var person1 = new Contestant(000);
            Console.WriteLine("Please enter the contestant's first name.");
            Console.WriteLine("Please enter the contestant's last name.");
            Console.WriteLine("Please enter a valid email address.");
            Console.WriteLine($"Contestant One's user information: {person1.ContestantFirstName}{person1.ContestantLastName}{person1.Email}{person1.ContestantRegistrationNumber}");
            Console.ReadLine();

            var person2 = new Contestant(001);
            Console.WriteLine("Please enter the contestant's first name.");
            Console.WriteLine("Please enter the contestant's last name.");
            Console.WriteLine("Please enter a valid email address.");
            Console.WriteLine($"Contestant Two's user information: {person2.ContestantFirstName}{person2.ContestantLastName}{person2.Email}{person2.ContestantRegistrationNumber}");
            Console.ReadLine();

            var person3 = new Contestant(002);
            Console.WriteLine("Please enter the contestant's first name.");
            Console.WriteLine("Please enter the contestant's last name.");
            Console.WriteLine("Please enter a valid email address.");
            Console.WriteLine($"Contestant Three's user information: {person3.ContestantFirstName}{person3.ContestantLastName}{person3.Email}{person3.ContestantRegistrationNumber}");
            Console.ReadLine();

            var person4 = new Contestant(003);
            Console.WriteLine("Please enter the contestant's first name.");
            Console.WriteLine("Please enter the contestant's last name.");
            Console.WriteLine("Please enter a valid email address.");
            Console.WriteLine($"Contestant Fours's user information: {person4.ContestantFirstName}{person4.ContestantLastName}{person4.Email}{person4.ContestantRegistrationNumber}");
            Console.ReadLine();

            var person5 = new Contestant(004);
            Console.WriteLine("Please enter the contestant's first name.");
            Console.WriteLine("Please enter the contestant's last name.");
            Console.WriteLine("Please enter a valid email address.");
            Console.WriteLine($"Contestant Five's user information: {person5.ContestantFirstName}{person5.ContestantLastName}{person5.Email}{person5.ContestantRegistrationNumber}");
            Console.ReadLine();
        }

        public void SweepStakesName()
        {
            var name = new Sweepstakes("");
            
        }

    }
}

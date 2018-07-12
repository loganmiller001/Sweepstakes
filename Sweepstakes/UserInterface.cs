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
            int contestants;
            for (contestants = 0; contestants < 4; contestants++)
            {
                var person = new Contestant();
                Console.WriteLine($"Your registration number is: {RegistrationNumber}");
                Console.WriteLine("Please enter the contestant's first name.");
                person.ContestantFirstName = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter the contestant's last name.");
                person.ContestantLastName = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter a valid email address.");
                person.Email = Console.ReadLine().ToLower();
                Console.WriteLine($"Contestant's user information: {person.ContestantFirstName}, {person.ContestantLastName}, {person.Email}, {RegistrationNumber}");
                Console.ReadLine().ToLower();
                RegistrationNumber++;
            }
          
        }

        public static void SweepStakesName()
        {
            var name = new Sweepstakes("Very Lame Name");
            
        }

    }
}

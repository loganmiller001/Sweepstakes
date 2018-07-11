using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    abstract class UserInterface
    {
         UserInterface()
        {

        }

         void GetContestantInfo(Contestant contestant)
        {
            var person = new Contestant("", "", "", 0000);
            Console.WriteLine($"{person.ContestantFirstName}, {person.ContestantLastName}, {person.Email}, {person.ContestantRegistrationNumber}");
        }

    }
}

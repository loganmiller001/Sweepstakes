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
            var person = new Contestant("", "", "", 0000);
            Console.WriteLine($"{person.ContestantFirstName}, {person.ContestantLastName}, {person.Email}, {person.ContestantRegistrationNumber}");
        }

        public void SweepStakesName(Sweepstakes sweepstakes)
        {
            var name = new Sweepstakes("");
            
        }

    }
}

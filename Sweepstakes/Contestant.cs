using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        int registrationNumber;
        string firstName;
        string lastName;
        string emailAddress;


        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }

        public string Email
        {
            get => emailAddress;
            set => emailAddress = value;

        }
        public string ContestantFirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string ContestantLastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int ContestantRegistrationNumber
        {
            get => registrationNumber;
            set => registrationNumber = value;
        }
    }
}

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
            Console.WriteLine("Please enter the contestants first name.");
            Console.WriteLine($"First Name: {person1.ContestantFirstName}");
            Console.ReadLine();

            var person2 = new Contestant(001);
            Console.WriteLine("Please enter the contestants first name.");
            Console.WriteLine($"First Name: {person2.ContestantFirstName}");
            Console.ReadLine();

            var person3 = new Contestant(002);
            Console.WriteLine("Please enter the contestants first name.");
            Console.WriteLine($"First Name: {person3.ContestantFirstName}");
            Console.ReadLine();

            var person4 = new Contestant(003);
            Console.WriteLine("Please enter the contestants first name.");
            Console.WriteLine($"First Name: {person4.ContestantFirstName}");
            Console.ReadLine();

            var person5 = new Contestant(004);
            Console.WriteLine("Please enter the contestants first name.");
            Console.WriteLine($"First Name: {person5.ContestantFirstName}");
            Console.ReadLine();
        }

        public void SweepStakesName()
        {
            var name = new Sweepstakes("");
            
        }

    }
}

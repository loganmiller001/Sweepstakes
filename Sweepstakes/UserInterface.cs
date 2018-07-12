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
            
            Console.WriteLine($"Your registration number is: {RegistrationNumber}");
            Console.WriteLine("Please enter the contestant's first name.");
            contestant.ContestantFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the contestant's last name.");
            contestant.ContestantLastName = Console.ReadLine();
            Console.WriteLine("Please enter a valid email address.");
            contestant.Email = Console.ReadLine();
            Console.WriteLine($"Contestant's user information: {contestant.ContestantFirstName}, {contestant.ContestantLastName}, {contestant.Email}, {RegistrationNumber}");
            Console.ReadLine().ToLower();
            




        }

        public static void GetSweepStakesName()
        {
            var name = new Sweepstakes("Very Lame Name");
            
        }
        public static void ChooseDataStructure()
        {
            Console.WriteLine("Please type if you would like to pull sweepstakes from a stack or queue.");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "stack":
                    SweepstakeStackManager newStack = SweepstakesFactory.CreateStack();
                    break;
                case "queue":
                    SweepstakeQueueManager newQueue = SweepstakesFactory.CreateQueue();
                    break;
                default:
                    Console.WriteLine("incorrect input, please try again.");
                    ChooseDataStructure();
                    break;
            }
        }
    }
}

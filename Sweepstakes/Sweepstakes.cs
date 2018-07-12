using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes:UserInterface
    {
        string contestName;
        public int RegistrationNumber { get; set; }
        public UserInterface ui;
        Dictionary<int, Contestant> contestantDraw = new Dictionary<int, Contestant>();



        public Sweepstakes(string contestName)
        {
           
            this.contestName = contestName;
        }
 

        

        public string SweepStakesName(string contestName)
        {
            GetSweepStakesName();
            Console.WriteLine($"{contestName} is the name of this Sweepstakes!");
            return contestName;
        }

        public void RegisterContestant(Contestant contestant)
        {
            int contestants;
            for (contestants = 0; contestants < 4; contestants++)
            {

                Contestant constestant = new Contestant();
                contestant.ContestantRegistrationNumber = RegistrationNumber;
                GetContestantInfo(contestant, RegistrationNumber);
                contestantDraw.Add(RegistrationNumber, contestant);
                RegistrationNumber++;
            }


        }

        public string PickWinner()
        {
            Random randomRegisterNumber = new Random();
            RegistrationNumber = randomRegisterNumber.Next(0, contestantDraw.Count);
            
            string winner = RegistrationNumber.ToString();
            Console.WriteLine($"{winner} has won the drawing!");
            Console.ReadLine();
            return winner;
        }

        public void PrintContestantInfo()
        {
            

            foreach (KeyValuePair<int, Contestant> contestant in contestantDraw)
            {
                Console.WriteLine($"Contestant's Information: {contestant.Value.ContestantFirstName}, {contestant.Value.ContestantLastName}, {contestant.Value.Email}, {RegistrationNumber},");
                Console.ReadKey();
            }
        }


        public void RunContest(Contestant contestant)
        {
            
            RegisterContestant(contestant);
            PrintContestantInfo();
            PickWinner();
            Console.ReadLine();
        }

    }
}

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
        public UserInterface ui;
        
        
        

        public Sweepstakes(string contestName)
        {
            this.contestName = contestName;
        }

        Dictionary<string, int> contestantDraw = new Dictionary<string, int>();

        public string SweepStakesName(string contestName)
        {
            ui.SweepStakesName();
            Console.WriteLine($"{contestName} is the name of this Sweepstakes!");
            return contestName;
        }

        public void RegisterContestant(Contestant contestant)
        {

            ui.GetContestantInfo(contestant);
            Console.WriteLine($"{contestant.ContestantRegistrationNumber} has been registered.");

        }

        public string PickWinner()
        {

        }
    }
}

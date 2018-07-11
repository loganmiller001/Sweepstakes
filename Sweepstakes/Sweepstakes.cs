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
        Contestant contestant;
        
        
        

        public Sweepstakes(string contestName)
        {
            this.contestName = contestName;
        }

        Dictionary<int, object> contestantDraw = new Dictionary<int, object>();
        

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

            
            string winner = contestant.ContestantRegistrationNumber.ToString();
            Console.WriteLine($"{winner} has won the drawing!");
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            ui.GetContestantInfo(contestant);
        }
    }
}

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
        Dictionary<int, object> contestantDraw = new Dictionary<int, object>();



        public Sweepstakes(string contestName)
        {
            this.contestName = contestName;
        }

        public void ContestantDictionary()
        {
            Dictionary<int, object> contestantDraw = new Dictionary<int, object>();
            contestantDraw.Add(000, contestant);
            contestantDraw.Add(001, contestant);
            contestantDraw.Add(002, contestant);
            contestantDraw.Add(003, contestant);
            contestantDraw.Add(004, contestant);

        }

        public string SweepStakesName(string contestName)
        {
            ui.SweepStakesName();
            Console.WriteLine($"{contestName} is the name of this Sweepstakes!");
            return contestName;
        }

        public void RegisterContestant(Contestant contestant)
        {

            ui.GetContestantInfo(contestant);
            Console.WriteLine($"Contestant {contestant.ContestantRegistrationNumber} has been registered.");

        }

        public string PickWinner()
        {
            Random randomRegisterNumber = new Random();
            contestant.ContestantRegistrationNumber = randomRegisterNumber.Next(000, 004);
            
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

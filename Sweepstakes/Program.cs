using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {





            Contestant contestant = new Contestant();
            Sweepstakes sweepstakes = new Sweepstakes("");
            SweepstakesManager.BeginProgram();
            sweepstakes.RunContest(contestant);
            UserInterface.EndProgram();

        }
    }
}

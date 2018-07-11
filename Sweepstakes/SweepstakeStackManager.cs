using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakeStackManager:ISweepstakesManager
    {

        public SweepstakeStackManager()
        {

        }
        public static void Stack()
        {
            Stack<string> sweepstakeStack = new Stack<string>();
            sweepstakeStack.Push("SweepStake1");
            sweepstakeStack.Push("SweepStake2");
            sweepstakeStack.Push("SweepStake3");
            sweepstakeStack.Push("SweepStake4");

        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("");
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            GetSweepstakes();
        }
    }
}

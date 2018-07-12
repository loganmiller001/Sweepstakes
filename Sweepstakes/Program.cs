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


            //SweepstakeQueueManager newQueue = SweepstakesFactory.CreateQueue();
            //SweepstakeStackManager newStack = SweepstakesFactory.CreateStack();

            
            Sweepstakes sweepstakes = new Sweepstakes("");
            sweepstakes.RunContest();


        }
    }
}

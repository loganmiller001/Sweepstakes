using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class SweepstakesFactory
    {
        public static SweepstakeStackManager CreateStack()
        {
            return new SweepstakeStackManager();
        }

        public static SweepstakeQueueManager CreateQueue()
        {
            return new SweepstakeQueueManager();
        }
    }
}

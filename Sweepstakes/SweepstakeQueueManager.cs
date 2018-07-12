using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakeQueueManager:ISweepstakesManager
    {

        public SweepstakeQueueManager()
        {
            Queue();
        }
        public static void Queue()
        {
            Queue<string> sweepstakesQueue = new Queue<string>();
            sweepstakesQueue.Enqueue("Sweepstake1");
            sweepstakesQueue.Enqueue("Sweepstake2");
            sweepstakesQueue.Enqueue("Sweepstake3");
            sweepstakesQueue.Enqueue("Sweepstake4");

            Console.WriteLine("Elements in queue: ");
            foreach(string word in sweepstakesQueue)
            {
                Console.WriteLine(word);
            }

            string startOfQueue = sweepstakesQueue.Dequeue();
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

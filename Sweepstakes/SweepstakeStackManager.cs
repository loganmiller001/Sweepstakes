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
            Stack();
        }
        public static void Stack()
        {
            Stack<string> sweepstakeStack = new Stack<string>();
            sweepstakeStack.Push("SweepStake8");
            sweepstakeStack.Push("SweepStake7");
            sweepstakeStack.Push("SweepStake6");
            sweepstakeStack.Push("SweepStake5");

            Console.WriteLine("Elements in stack: ");
            foreach(string word in sweepstakeStack)
            {
                Console.WriteLine(word);
            }
            string topOfStack = sweepstakeStack.Pop();
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

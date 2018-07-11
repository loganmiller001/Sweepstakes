using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {

        //public readonly ISweepstakesManager _sweepstakesManager;

        //public MarketingFirm() : this(DependencyFactory.Resolve<ISweepstakesManager>())
        //{

        //}

        //public MarketingFirm(ISweepstakesManager sweepstakesManager)
        //{
        //    _sweepstakesManager = sweepstakesManager;
        //}

        public ISweepstakesManager SweepstakesManager { get; set; }

    }
        public class SweepstakesManager
        {

        }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal abstract class SimpleAnalysis : IStrategy
    {


        public void Analyze()
        {
            Start();
            SkipZIP();
            Stop();
        }

        public abstract void Start();
        public abstract void SkipZIP();
        public abstract void Stop();
    }
}

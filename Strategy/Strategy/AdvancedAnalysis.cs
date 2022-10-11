using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal abstract class AdvancedAnalysis : IStrategy
    {
        public void Analyze()
        {
            Start();
            AnalyzeMemory();
            AnalyzeKeyLoggers();
            AnalyzeRootKits();
            DecompressZIP();
            Stop();
        }

        public abstract void Start();
        public abstract void AnalyzeMemory();
        public abstract void AnalyzeKeyLoggers();
        public abstract void AnalyzeRootKits();
        public abstract void DecompressZIP();
        public abstract void Stop();

    }
}

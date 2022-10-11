using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal class AntivirusSimple : SimpleAnalysis
    {
        public override void SkipZIP()
        {
            try
            {
                Console.WriteLine("Analyzing...");
                Thread.Sleep(2500);
                Console.WriteLine("Unable to analyze ZIP files");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override void Start()
        {
            Console.WriteLine("Simple Antivirus - Simple Analysis Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Simple Antivirus - Simple Analysis Finished");
        }
    }
}

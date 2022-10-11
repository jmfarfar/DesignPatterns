using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal class AntivirusAdvanced : AdvancedAnalysis
    {
        public override void AnalyzeKeyLoggers()
        {
            try
            {
                Console.WriteLine("Analyze Keyloggers");
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override void AnalyzeMemory()
        {
            try
            {
                Console.WriteLine("Analyzing RAM... ");
                Thread.Sleep(1000);
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override void AnalyzeRootKits()
        {
            try
            {
                Console.WriteLine("Analyze Rootkits");
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override void DecompressZIP()
        {
            try
            {
                Console.WriteLine("Analyzing ZIP files");
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override void Start()
        {
            Console.WriteLine("Advanced Antivirus - Analysis started");
        }

        public override void Stop()
        {
            Console.WriteLine("Advanced Antivirus - Analysis finished");
        }
    }
}

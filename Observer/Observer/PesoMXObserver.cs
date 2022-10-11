using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    internal class PesoMXObserver : Observer
    {

        private double rate = 13.65;

        public PesoMXObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine($"MX: {subject.GetState() * rate}");
        }
    }
}

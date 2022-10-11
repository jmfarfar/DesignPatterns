using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    internal class PesoArgObserver : Observer
    {

        private double rate = 29.86;

        public PesoArgObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine($"ARG: {subject.GetState() * rate}");
        }
    }
}

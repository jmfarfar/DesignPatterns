using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    internal class SolObserver : Observer
    {
        private double rate = 3.25;

        public SolObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }        

        public override void Update()
        {
            Console.WriteLine($"PEN: {subject.GetState() * rate}");
        }
    }
}

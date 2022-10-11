using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    internal abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}

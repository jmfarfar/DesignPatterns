using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    internal class Memento
    {
        private Game state;

        public Memento(Game state)
        {
            this.state = state;
        }

        internal Game GetState()
        {
            return state;
        }
    }
}

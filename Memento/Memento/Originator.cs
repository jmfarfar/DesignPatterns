using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    internal class Originator
    {
        private Game state;

        internal Game GetState()
        {
            return state;
        }

        internal void Restore(Memento m)
        {
            state = m.GetState();
        }

        internal Memento Save()
        {
            return new Memento(state);
        }

        internal void SetState(Game game)
        {
            state = game;    
        }
    }
}

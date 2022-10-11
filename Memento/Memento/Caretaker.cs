using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    internal class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        internal void AddMemento(Memento m)
        {
            mementos.Add(m);
        }

        internal Memento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}

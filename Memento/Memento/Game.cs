using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    internal class Game
    {
        private string _gameName;
        private int _checkpoint;

        internal void SetCheckpoint(int checkpoint)
        {
            _checkpoint = checkpoint;
        }

        internal int GetCheckpoint()
        {
            return _checkpoint;
        }

        internal void SetName(string gameName)
        {
            _gameName = gameName;
        }

        internal string GetName()
        {
            return _gameName;
        }

        public override string ToString()
        {
            return $"Game [name: {_gameName}, Checkpoint: {_checkpoint}]";
        }
    }
}

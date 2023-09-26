using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            _mementos.Remove(_mementos.Last());

            _originator.Restore(_mementos.Last());
        }
    }
}

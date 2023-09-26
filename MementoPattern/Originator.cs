using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private int _state;

        public Originator(int state)
        {
            _state = state;
            Console.WriteLine($"Initial value of the state is {_state}");
        }

        public void ChangeState(int maxLimit=50)
        {
            var rng = new Random();
            _state=rng.Next(maxLimit);
        }

        public IMemento Save()
        {
            Console.WriteLine("New snapshot is saving, new state is "+ _state);
            return new ConcreteMemento(_state);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Wrong type" +memento.GetType());
            }

            _state=memento.GetState();

            Console.WriteLine($"State changed to {memento} in restore");
        }

    }
}

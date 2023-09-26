using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class ConcreteMemento : IMemento
    {
        private int _state;

        public ConcreteMemento(int state)
        {
            _state = state;
        }

        public int GetState()
        {
            return _state;
        }

        //Just for showcase purposes, normally _state should be close to outside
        public override string ToString()
        {
            return _state.ToString();
        }
    }
}

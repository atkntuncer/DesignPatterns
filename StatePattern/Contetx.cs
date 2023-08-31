using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        private static BaseState? _state;

        public Context()
        {
            _state = new State1();
        }

        public void MoveNext() => _state = _state?.MoveNext();

        public void MoveBack() => _state = _state?.MovePrevious();
    }
}

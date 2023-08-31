using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class State3 : BaseState
    {
        public State3()
        {
            Console.WriteLine("You are on state 3");
            //Some other state configs
        }

        public override BaseState MoveNext()
        {
            throw new InvalidOperationException("Wrong move");
        }

        public override BaseState MovePrevious()
        {
            Console.WriteLine("Moving back from three");
            return new State2();
        }
    }
}

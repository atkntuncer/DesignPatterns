using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class State1 : BaseState
    {
        public State1()
        {
            Console.WriteLine("You are on state 1");
            //Some other state configs
        }
        public override BaseState MoveNext()
        {
            Console.WriteLine("Moving forward from one");
            return new State2();
        }

        public override BaseState MovePrevious()
        {
            throw new InvalidOperationException("Wrong move");
        }
    }
}

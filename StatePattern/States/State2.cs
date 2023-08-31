using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class State2 : BaseState
    {
        public State2()
        {
            Console.WriteLine("You are on state 2");
            //Some other state configs
        }

        public override BaseState MoveNext()
        {
            Console.WriteLine("Moving forward from two");
            return new State3();
        }


        public override BaseState MovePrevious()
        {
            Console.WriteLine("Moving back from two");
            return new State1();
        }
    }
}

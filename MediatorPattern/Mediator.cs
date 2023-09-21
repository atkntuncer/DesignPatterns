using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Mediator : IMediator
    {
        private readonly ComponentA _compA;
        private readonly ComponentB _compB;

        public Mediator(ComponentA compA, ComponentB compB)
        {
            _compA = compA;
            _compB = compB;
        }
        public void Execute(string data)
        {
            if (data == "A")
            {
                Console.WriteLine("A is executed in mediator.");
                _compA.DoB(this);
            }
            if (data == "C")
            {
                Console.WriteLine("C is executed in mediator.");
                _compA.DoB(this);
                _compB.DoD(this);
            }
        }
    }
}

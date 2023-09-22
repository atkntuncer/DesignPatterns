using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Increase and decrease requests transfer into command objects here
    public class Command : ICommand
    {
        private readonly Receiver _receiver;
        private readonly int _amount;
        private readonly bool _isIncrease;

        public Command(Receiver receiver,int amount, bool isIncrease)
        {
            _receiver = receiver;
            _amount = amount;
            _isIncrease = isIncrease;
        }
        public void Execute()
        {
            if (_isIncrease)
            {
                _receiver.IncreaseAmount(_amount);
            }
            else
            {
                _receiver.DecreaseAmount(_amount);
            }
        }

        public void Undo()
        {
            if (!_isIncrease)
            {
                _receiver.IncreaseAmount(_amount);
            }
            else
            {
                _receiver.DecreaseAmount(_amount);
            }
        }
    }
}

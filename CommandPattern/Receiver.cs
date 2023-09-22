using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommandPattern
{
    public class Receiver
    {
        public int Amount { get; private set; }

        public Receiver(int amount)
        {
            Amount = amount;
        }

        public void IncreaseAmount(int amount)
        {
            Amount += amount;
        }

        public void DecreaseAmount(int amount)
        {
            Amount -= amount;
        }
    }
}

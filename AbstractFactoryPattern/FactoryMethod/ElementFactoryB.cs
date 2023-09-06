using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryMethod
{
    public class ElementFactoryB : Product
    {
        public override Element CreateElement()
        {
            return new Element("Element B");
        }
    }
}

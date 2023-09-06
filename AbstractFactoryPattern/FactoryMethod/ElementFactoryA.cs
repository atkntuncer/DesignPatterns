using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryMethod
{
    public class ElementFactoryA : Product
    {
        public override Element CreateElement()
        {
            return new Element("Element A");
        }
    }
}

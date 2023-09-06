using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //Concrete factory
    public class ElementBFactory : IElementFactory
    {
        public Element CreateElement()
        {
            return new Element("ElementB");
        }
    }
}

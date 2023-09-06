using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //Concrete Factory
    public class ElementAFactory : IElementFactory
    {
        public Element CreateElement()
        {
            return new Element("ElementA");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //Abstract factory
    public interface IElementFactory
    {
        public Element CreateElement();
    }
}

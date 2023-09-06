using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryMethod
{
    //Includes factory method
    public abstract class Product
    {
        public abstract Element CreateElement();

        public Product()
        {
            CreateElement();
        }
    }
}

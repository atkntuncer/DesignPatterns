using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Product
    {
        private List<string> _elements = new();

        public void Add(string element)
        {
            _elements.Add(element);
        }

        public List<string> GetProduct()
        {
            return _elements;
        }
    }
}

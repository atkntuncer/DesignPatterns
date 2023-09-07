using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Builder : IBuilder
    {
        private Product product;
        public Builder()
        {
            product = new();
        }

        public Builder BuildElementA()
        {
            product.Add("Element A");
            return this;
        }

        public Builder BuildElementB()
        {
            product.Add("Element B");
            return this;
        }

        public Builder BuildElementC()
        {
            product.Add("Element C");
            return this;
        }

        public void Build()
        {
            foreach (var item in product.GetProduct())
            {
                Console.WriteLine(item);
            }
        }
    }
}

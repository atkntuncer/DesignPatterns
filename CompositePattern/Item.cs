using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    //Leaf in the tree so can't have branch or leaf under itself
    public class Item : Component
    {
        public override string ToText()
        {
            return "Item";
        }
    }
}

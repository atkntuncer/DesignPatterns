using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Items
{
    public interface IItem
    {
        public int Id { get; }
        public string Name { get;}
    }
}

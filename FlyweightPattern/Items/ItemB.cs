using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Items
{
    public record ItemB(int id, string name, decimal cost) : IItem
    {
        public int Id { get; init; } = id;
        public string Name { get; init; } = name;
    }
}

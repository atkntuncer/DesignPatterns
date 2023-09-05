using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Items
{
    public record ItemC(int id, string name, string description) : IItem
    {
        public int Id { get; init; } = id;
        public string Name { get; init; }= name;
    }
}

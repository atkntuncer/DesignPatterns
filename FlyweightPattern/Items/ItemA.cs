using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Items
{
    //Record is used due to it's immutability and value equility nature
    public record ItemA(int id, string name, DateTime date) : IItem
    {
        public int Id { get; init; } = id;
        public string Name { get; init; } = name;
    }
}

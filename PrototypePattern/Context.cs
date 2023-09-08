using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Context
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }

        public Context DeepCopy()
        {
            var clone = (Context)this.MemberwiseClone();
            clone.Id = Id;
            clone.Name = Name;
            clone.Description = Description;
            clone.Date = Date;
            return clone;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Description:{Description}, Date:{Date.ToString()}";
        }
    }
}

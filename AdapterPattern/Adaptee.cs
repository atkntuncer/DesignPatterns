using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adaptee : IAdaptee
    {
        public void DoSomeWork(string extraContent)
        {
            Console.WriteLine($"Adaptee do its work with {extraContent}");
        }
    }
}

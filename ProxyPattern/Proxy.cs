using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : IContext
    {
        private Context _context;

        public Proxy(Context context)
        {
           _context = context;
        }
        public void DoSomeWork()
        {
            if (Check())
            {
                _context.DoSomeWork();
            }
        }

        private bool Check()
        {
            Console.WriteLine("Checking in proxy...");
            return true;
        }
    }
}

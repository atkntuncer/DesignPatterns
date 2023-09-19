using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class InterpreterB:IInterpreter
    {
        public void Interpret(Context context)
        {
            context.Name = "Interpreted by Interpreter B";
        }
    }
}

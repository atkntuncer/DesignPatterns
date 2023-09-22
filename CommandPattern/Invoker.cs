using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CommandPattern
{
    public static class Invoker
    {
        static List<ICommand> commands = new List<ICommand>();


        public static void Invoke(ICommand command)
        {
            commands.Add(command);
            command.Execute();
        }

        public static void Undo(ICommand command)
        {
            if (commands.Contains(command))
            {
                commands.Remove(command);
                command.Undo();
            }
        }
    }
}

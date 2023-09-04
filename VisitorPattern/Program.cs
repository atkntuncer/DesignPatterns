using VisitorPattern.Components;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    //Adding new behavior without changing any code
    //Better with complex hierarchy like Composite Pattern
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> list = new List<IComponent>();

            list.Add(new ComponentA());
            list.Add(new ComponentB());

            Visitor1 visitor1 = new();
            Visitor2 visitor2 = new();

            foreach (var item in list)
            {
                item.Accept(visitor1);
            }

            Console.WriteLine( );

            foreach (var item in list)
            {
                item.Accept(visitor2);
            }
        }
    }
}
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

            var comA = new ComponentA();
            var comB = new ComponentB();

            Visitor1 visitor1 = new();
            Visitor2 visitor2 = new();

            comA.Accept(visitor1);
            Console.WriteLine();
            comB.Accept(visitor2);

        }
    }
}
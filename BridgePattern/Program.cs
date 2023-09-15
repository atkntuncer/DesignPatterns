using BridgePattern.Abstraction;
using BridgePattern.Implementation;

namespace BridgePattern
{
    //Separates abstraction and implementation creation so don't need to cross creation when they use each other
    //Otherwise there would be hundreds of new classes for complex systems
    //In other words divides huge class into seperate classes so they can be developed independently
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction.Abstraction abs = new(new ImplementationA());
            abs.Operation();

            Console.WriteLine();

            abs = new ExtraAbstraction(new ImplementationB());
            abs.Operation();
        }
    }
}
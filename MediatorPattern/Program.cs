namespace MediatorPattern
{
    //Creates an object to centralise the communication between objects
    //Reduces coupling
    //Mediatr is a good library for this pattern
    internal class Program
    {
        static void Main(string[] args)
        {
            var compA = new ComponentA();
            var compB = new ComponentB();
            var mediator = new Mediator(compA, compB);

            compA.DoA(mediator);
            compB.DoC(mediator);
        }
    }
}
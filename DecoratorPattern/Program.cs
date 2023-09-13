namespace DecoratorPattern
{
    //Purpose of this pattern adding new behaviours dynamically for example in run-time
    //Can wrap the default behaviour multiple time
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseDecorator = new Context();
            baseDecorator.DoSomeWork();

            Console.WriteLine();

            var anotherDecorator = new FirstDecorator(baseDecorator);
            anotherDecorator.DoSomeWork();

            Console.WriteLine();

            var inAdditionDecorator = new AnotherDecorator(anotherDecorator);
            inAdditionDecorator.DoSomeWork();

            Console.WriteLine();

            var inAdditionDecorator2 = new AnotherDecorator(baseDecorator);
            inAdditionDecorator2.DoSomeWork();
        }
    }
}
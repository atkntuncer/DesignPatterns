namespace FacadePattern
{
    //Provides simplified interface to complex systems
    //I think this one is the most used unconciously among design patterns 
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade(new Operations.OperationA(), new Operations.OperationB(), new Operations.OperationC());

            facade.OperateAandC();

            Console.WriteLine();

            facade.FullOperation();
        }
    }
}
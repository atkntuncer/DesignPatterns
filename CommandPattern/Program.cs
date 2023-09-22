namespace CommandPattern
{
    //We can use this to turn a request into an object which contains all the information about the request
    internal class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver(20);

            var com1 = new Command(receiver, 10, true);
            var com2=new Command(receiver, 20, false);
            var com3 = new Command(receiver, 100, true);

            Invoker.Invoke(com1);
            Console.WriteLine("Amount is: "+receiver.Amount);

            Invoker.Invoke(com2);
            Console.WriteLine("Amount is: "+receiver.Amount);

            Invoker.Invoke(com3);
            Console.WriteLine("Amount is: " + receiver.Amount);

            Invoker.Undo(com2);
            Console.WriteLine("Amount is: " + receiver.Amount);
        }
    }
}
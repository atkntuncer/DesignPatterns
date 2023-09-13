namespace AdapterPattern
{
    //Allows different objects to adapt each other, aka wrapper
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget client = new Client();
            client.DoSomeWork();

            IAdaptee adaptee = new Adaptee();
            Adapter adapter = new Adapter(adaptee);
            adapter.DoSomeWork();
        }
    }
}
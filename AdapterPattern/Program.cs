namespace AdapterPattern
{
    //Make different objects to collaborate, aka wrapper
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
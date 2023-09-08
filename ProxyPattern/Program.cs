namespace ProxyPattern
{
    //Create a proxy object with extra functionality while also using the real object
    //Especially good for adding new functionality without changing the base class code 
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.DoSomeWork();

            Console.WriteLine( );

            var proxy = new Proxy(context);
            proxy.DoSomeWork();
        }
    }
}
namespace ChainOfResponsibilityPattern
{
    //Allows passing request along the chain of potential handlers until one of them handles request.
    //For example middleware pipeline in asp .net is similar to this pattern(Authentication to authorarization, authorarization to router etc...)
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new HandlerA();
            var b = new HandlerB();
            var c = new HandlerC();

            a.SetNext(b).SetNext(c);

            a.Handle("A");
            //It can start from middle
            b.Handle("C");
            b.Handle("D");
        }
    }
}
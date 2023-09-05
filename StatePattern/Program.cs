namespace StatePattern
{
    //Create states
    //This pattern especially good for long if-else/switch-case structures, for small ones it can be an overkill.   
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new Context();
                context.MoveNext();
                context.MoveNext();
                context.MoveBack();
                context.MoveBack();
                context.MoveBack();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
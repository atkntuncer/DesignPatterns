namespace PrototypePattern
{
    //Simply used for cloning obejcts
    //Deep copy means that cloned object has no coupling with the other object
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctx1 = new Context { Id=1, Name="Context1", Description="First context", Date=DateTime.Now};
            var ctx2 = ctx1;
            var ctx3 = ctx1.DeepCopy();

            List<Context> list = new List<Context>
            {
                ctx1,
                ctx2,
                ctx3
            };

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            ctx1.Name = "New Context";
            ctx1.Description = "New Description";
            ctx1.Date = DateTime.Today;
            ctx3.Name = "Contetx3";
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
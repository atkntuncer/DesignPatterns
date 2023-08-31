namespace CompositePattern
{
    //Create hierarchical structure between classes
    internal class Program
    {
        static void Main(string[] args)
        { 
            Composite composite1 = new Composite();

            composite1.Add(new Item());
            composite1.Add(new Item());

            Composite composite2 = new Composite();

            Composite composite3 = new Composite();
            composite3.Add(new Item());

            composite2.Add(composite1);
            composite2.Add(composite3);
            Console.WriteLine(composite2.ToText()); 
        }
    }
}
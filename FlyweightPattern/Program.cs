namespace FlyweightPattern
{
    //Used in applications with a large number of objects, use the same object instead of creating new one
    //Makes the application more memory efficient
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ItemFactory();

            factory.CreateItemA(1, "A1", DateTime.Today);
            factory.CreateItemB(1, "B1", 10);
            factory.CreateItemC(1, "C1", "item c");

            //Same objects
            factory.CreateItemA(1, "A1", DateTime.Today);
            factory.CreateItemB(1, "B1", 10);
            factory.CreateItemC(1, "C1", "item c");

            //Different object 
            factory.CreateItemA(2, "A2", DateTime.Today);

            Console.WriteLine("Total created object: " + factory.objectCount);
        }
    }
}
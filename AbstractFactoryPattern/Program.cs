using AbstractFactoryPattern.FactoryMethod;

namespace AbstractFactoryPattern
{
    //Creates objects without specifying their concrete classes
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract 
            var app = new App();
            var elementA = app.CreateElement(new ElementAFactory());
            var elementB = app.CreateElement(new ElementBFactory());
            Console.WriteLine(elementA.Name);
            Console.WriteLine(elementB.Name);

            Console.WriteLine( );

            //Factory Method
            Console.WriteLine( new ElementFactoryA().CreateElement().Name);
            Console.WriteLine(new ElementFactoryB().CreateElement().Name);
        }
    }
}
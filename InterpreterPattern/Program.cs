namespace InterpreterPattern
{
    //Used for interpretation of input, change it to more understandable in the code
    //For example SQL apps interpret queries
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context("Plain name");
            Console.WriteLine(context.Name);
            Console.WriteLine();

            var interpreterA = new InterpreterA();
            interpreterA.Interpret(context);
            Console.WriteLine(context.Name);
            Console.WriteLine();

            var interpreterB = new InterpreterB();
            interpreterB.Interpret(context);
            Console.WriteLine(context.Name);
            Console.WriteLine();
        }
    }
}
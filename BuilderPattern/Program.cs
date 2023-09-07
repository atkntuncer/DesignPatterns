namespace BuilderPattern
{
    //Used for create different objects using same constructional process
    //It is better to use this pattern only when the objects are complex and require extensive configuration
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new Builder();
            FullBuild(builder);
            BuildWithAC(builder);
            builder.Build();
        }

        //Abstraction of the building different objects using builder is better 
        public static void FullBuild(IBuilder builder)
        {
            builder.BuildElementA().BuildElementB().BuildElementC();
        }

        public static void BuildWithAC(IBuilder builder)
        {
            builder.BuildElementA().BuildElementC();
        }
    }
}
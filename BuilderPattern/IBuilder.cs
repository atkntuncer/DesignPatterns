namespace BuilderPattern
{
    //Different builders can be created using this interface
    public interface IBuilder
    {
        void Build();
        Builder BuildElementA();
        Builder BuildElementB();
        Builder BuildElementC();
    }
}
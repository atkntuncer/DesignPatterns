namespace BuilderPattern
{
    public interface IBuilder
    {
        void Build();
        Builder BuildElementA();
        Builder BuildElementB();
        Builder BuildElementC();
    }
}
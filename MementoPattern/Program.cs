namespace MementoPattern
{
    //Used for creating snapshots and restoring in the future
    //State of the momento should be close to outside world
    internal class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator(10);
            var caretaker = new Caretaker(originator);

            originator.ChangeState(100);
            caretaker.Save();

            originator.ChangeState(200);
            caretaker.Save();

            caretaker.Undo();

            originator.ChangeState(200);
            caretaker.Save();
            originator.ChangeState(200);
            caretaker.Save();


        }
    }
}
namespace CommandPattern
{
    public interface IMoveCommand
    {
        void Execute(Direction direction);
        void Undo();
    }
}
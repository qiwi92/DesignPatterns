namespace CommandPattern
{
    public class MoveControler
    {
        private IMoveCommand _moveCommand;

        public MoveControler(IMoveCommand moveCommand)
        {
            _moveCommand = moveCommand;
        }
        
        public void Move(Direction direction)
        {
            _moveCommand.Execute(direction);
        }


        public void UndoLastMove()
        {
            _moveCommand.Undo();
        }
    }
}
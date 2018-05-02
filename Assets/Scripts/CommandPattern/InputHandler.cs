using UnityEngine;

namespace CommandPattern
{
    public class InputHandler
    {
        private readonly MoveControler _moveControler;

        public InputHandler(MoveControler moveControler)
        {
            _moveControler = moveControler;
        }
  
        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _moveControler.Move(Direction.Up);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _moveControler.Move(Direction.Right);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _moveControler.Move(Direction.Down);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _moveControler.Move(Direction.Left);
            }
            else if (Input.GetKeyDown(KeyCode.Backspace))
            {
                _moveControler.UndoLastMove();
            }
        }
    }
}
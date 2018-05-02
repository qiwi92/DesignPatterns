using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class MoveCommand : IMoveCommand
    {
        private readonly Move _move;

        private Stack<Direction> _directions;

        public MoveCommand(Move move)
        {
            _directions = new Stack<Direction>();
            _move = move;
        }

        public void Execute(Direction direction)
        {
            if (_move.To(direction))
            {
                _directions.Push(direction);
            }
        }

        public void Undo()
        {
            if (_directions.Count > 0)
            {
                var lastDirection = _directions.Pop();
                if (!_move.ToOpposite(lastDirection))
                {
                    _directions.Clear();
                }
            }
            else
            {
                Debug.Log("You are back at the start position, no more undo steps available!");
            }
        }
    }
}
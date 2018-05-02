using System;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace CommandPattern
{
    public class Move
    {
        private readonly IMoveable _moveable;
        private readonly CollisionHandler _collisionHandler;

        public Move(IMoveable moveable, CollisionHandler collisionHandler)
        {
            _moveable = moveable;
            _collisionHandler = collisionHandler;
        }

        public bool To(Direction direction)
        {
            _moveable.CurentDirection.Value = direction;

            var nextPosition = _moveable.Position.Value + GetVector(direction);
            if (_collisionHandler.NextMoveWillCollide(nextPosition))
            {
                return false;
            }

            _moveable.Position.Value = nextPosition;

            return true;
        }

        public bool ToOpposite(Direction direction)
        {
            _moveable.CurentDirection.Value = direction;

            var oppositeDirection = (Direction) (((int) direction + 2) % 4);

            var nextPosition = _moveable.Position.Value + GetVector(oppositeDirection);
            if (_collisionHandler.NextMoveWillCollide(nextPosition))
            {
                return false;
            }

            _moveable.Position.Value = nextPosition;

            return true;
        }

        public Vector2Int GetVector(Direction direction)
        {
            switch (direction)
            {
                case Direction.None:
                    return Vector2Int.zero;
                case Direction.Up:
                    return Vector2Int.up;
                case Direction.Right:
                    return Vector2Int.right;
                case Direction.Down:
                    return Vector2Int.down;
                case Direction.Left:
                    return Vector2Int.left;
            }

            throw new Exception("Invalid Direction");
        }
    }
}
using Assets.Scripts;
using UnityEngine;

namespace CommandPattern
{
    public class PlayerModel : IMoveable
    {
        public ReactiveProperty<Vector2Int> Position { get; set; }
        public ReactiveProperty<Direction> CurentDirection { get; set; }

        public PlayerModel()
        {
            Position = new ReactiveProperty<Vector2Int> {Value = Vector2Int.zero};
            CurentDirection = new ReactiveProperty<Direction> {Value = Direction.None};
            
        }
    }
}
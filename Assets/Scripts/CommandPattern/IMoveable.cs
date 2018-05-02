using Assets.Scripts;
using UnityEngine;

namespace CommandPattern
{
    public interface IMoveable
    {
        ReactiveProperty<Vector2Int> Position { get; set; }
        ReactiveProperty<Direction> CurentDirection { get; set; }
    }
}
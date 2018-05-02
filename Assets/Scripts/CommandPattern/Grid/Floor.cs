using UnityEngine;

namespace CommandPattern.Grid
{
    public class Floor : IGridCell
    {
        public bool IsOcupied
        {
            get { return false;}
        }

        public Vector2Int Position { get; set; }

        public Floor(Vector2Int position)
        {
            Position = position;
        }
    }
}
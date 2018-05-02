using UnityEngine;

namespace CommandPattern.Grid
{
    public class Rock : IGridCell
    {
        public bool IsOcupied
        {
            get { return true; }
        }

        public Vector2Int Position { get; set; }

        public Rock(Vector2Int position)
        {
            Position = position;
        }
    }
}
using UnityEngine;

namespace CommandPattern.Grid
{
    public interface IGridCell
    {
        bool IsOcupied { get; }
        Vector2Int Position { get; set; }
    }
}
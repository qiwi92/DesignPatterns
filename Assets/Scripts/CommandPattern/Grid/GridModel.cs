using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Grid
{
    public class GridModel
    {
        private readonly int _size;
        private readonly List<IGridCell> _gridCells;

        public GridModel(int size)
        {
            _size = size;
            _gridCells = new List<IGridCell>();
            SetUpGrid();
        }

        public List<IGridCell> GetGrid()
        {
            return _gridCells;
        }

        public int GetSize()
        {
            return _size;
        }

        public bool Contained(Vector2Int pos)
        {
            if (pos.x < _size - 1 && pos.x >= 0 &&
                pos.y < _size - 1 && pos.y >= 0)
            {
                return true;
            }

            return false;
        }

        private void SetUpGrid()
        {
            var randomPos = new Vector2Int(Random.Range(0,_size), Random.Range(0, _size));

            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    if (x == randomPos.x && y == randomPos.y)
                    {
                        var newFloorCell = new Rock(new Vector2Int(x, y));
                        _gridCells.Add(newFloorCell);
                    }
                    else
                    {
                        var newFloorCell = new Floor(new Vector2Int(x, y));
                        _gridCells.Add(newFloorCell);
                    }
                }
            }
        }
        
    }
}
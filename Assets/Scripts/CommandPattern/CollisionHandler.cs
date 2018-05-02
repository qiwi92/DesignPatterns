using System;
using CommandPattern.Grid;
using UnityEngine;

namespace CommandPattern
{
    public class CollisionHandler
    {
        private readonly GridModel _gridModel;

        public CollisionHandler(GridModel gridModel)
        {
            _gridModel = gridModel;
        }

        public bool NextMoveWillCollide(Vector2Int nextPos)
        {
            foreach (var gridCell in _gridModel.GetGrid())
            {
                if (gridCell.Position == nextPos)
                {
                    return gridCell.IsOcupied;
                }
            }

            return true;
        }
    }
}
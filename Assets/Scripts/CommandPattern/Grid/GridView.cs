using UnityEngine;

namespace CommandPattern.Grid
{
    public class GridView : MonoBehaviour
    {
        public void Setup(GridModel gridModel, GridCellView gridCellView)
        {
            foreach (var gridCell in gridModel.GetGrid())
            {
                var newGridCellView = Instantiate(gridCellView, transform);
                newGridCellView.SetPosition(gridCell.Position);
                newGridCellView.SetColor(gridCell.IsOcupied);
            }
        }
    }
}
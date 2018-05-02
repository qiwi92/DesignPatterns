using UnityEngine;

namespace CommandPattern.Grid
{
    public class GridFactory : MonoBehaviour
    {
        [SerializeField] private GridCellView _gridCellPrefab;
        [SerializeField] private GridView _gridPrefab;

        public GridModel CreateGrid(int size, Transform trans)
        {
            var gridModel = new GridModel(size);

            var newGrid = Instantiate(_gridPrefab, trans);
            newGrid.Setup(gridModel,_gridCellPrefab);

            return gridModel;
        }
    }
}
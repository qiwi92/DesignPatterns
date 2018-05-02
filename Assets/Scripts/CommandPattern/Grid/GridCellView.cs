using UnityEngine;

namespace CommandPattern.Grid
{
    public class GridCellView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public void SetPosition(Vector2 position)
        {
            transform.position = position;
        }

        public void SetColor(bool isOcupied)
        {
            _spriteRenderer.color = isOcupied ? Color.red : Color.gray;
        }
    }
}
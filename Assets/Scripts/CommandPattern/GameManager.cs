using CommandPattern.Grid;
using UnityEngine;

namespace CommandPattern
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerFactory _playerFactory;
        [SerializeField] private GridFactory _gridFactory;

        private InputHandler _inputHandler;

        private void Start()
        {
            var gridModel = _gridFactory.CreateGrid(10, transform);
            var collisionHandler = new CollisionHandler(gridModel);

            var playerModel = _playerFactory.CreatePlayer(transform);
            _inputHandler = _playerFactory.CreateInputHandler(playerModel, collisionHandler);
        }

        private void Update()
        {
            _inputHandler.HandleInput();
        }
    }
}
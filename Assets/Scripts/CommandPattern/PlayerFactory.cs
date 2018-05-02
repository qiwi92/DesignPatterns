using UnityEngine;

namespace CommandPattern
{
    public class PlayerFactory : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;

        public PlayerModel CreatePlayer(Transform trans)
        {
            var playerModel = new PlayerModel();

            var playerView = Instantiate(_playerView, trans);
            playerView.Setup(playerModel);

            return playerModel;
        }

        public InputHandler CreateInputHandler(PlayerModel playerModel, CollisionHandler collisionHandler)
        { 
            var move = new Move(playerModel, collisionHandler);
            var moveCommand = new MoveCommand(move);
            var moveController = new MoveControler(moveCommand);

            return new InputHandler(moveController);
        }
    }
}
using UnityEngine;

namespace StateMaschine
{
    public class PlayerStateView : MonoBehaviour
    {
        private Player _player;
        private PlayerStateMaschine _playerStateMaschine;

        private void Start()
        {
            _player = new Player();

            _playerStateMaschine = new PlayerStateMaschine(_player);

            _playerStateMaschine.TakeDamage(10);
            _playerStateMaschine.TakeDamage(20);
            _playerStateMaschine.TakeDamage(100);
        }
    }
}
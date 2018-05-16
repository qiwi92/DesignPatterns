using UnityEngine;

namespace StateMaschine
{
    public class AliveState : IPlayerState
    {
        private readonly PlayerStateMaschine _playerStateMaschine;
        private Player _player;

        public AliveState(PlayerStateMaschine playerStateMaschine, Player player)
        {
            _playerStateMaschine = playerStateMaschine;
            _player = player;
        }

        public void Spawn()
        {
            Debug.Log("Player is already alive!");
        }

        public void TakeDamage(int dmg)
        {
            Debug.Log("Player took " + dmg + " damage!");
            if (_player.TakeDamage(dmg))
            {
                _playerStateMaschine.SetState(_playerStateMaschine.GetAliveState());
            }
            else
            {
                _playerStateMaschine.Die();
                _playerStateMaschine.Spawn();
            }
        }

        public void Die()
        {
            _playerStateMaschine.SetState(_playerStateMaschine.GetDeadState());
        }
    }
}
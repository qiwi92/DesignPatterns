using UnityEngine;

namespace StateMaschine
{
    public class DeadState : IPlayerState
    {
        private readonly PlayerStateMaschine _playerStateMaschine;
        private Player _player;

        public DeadState(PlayerStateMaschine playerStateMaschine, Player player)
        {
            _playerStateMaschine = playerStateMaschine;
            _player = player;
        }

        public void Spawn()
        {
            _playerStateMaschine.SetState(_playerStateMaschine.GetAliveState());
        }

        public void TakeDamage(int dmg)
        {
            Debug.Log("Cannot take more damage, player is already dead!");
        }

        public void Die()
        {
            Debug.Log("Player is already dead!");
        }
    }
}
using UnityEngine;

namespace StateMaschine
{
    public class DeadState : IPlayerState
    {
        private readonly PlayerStateMaschine _playerStateMaschine;

        public DeadState(PlayerStateMaschine playerStateMaschine)
        {
            _playerStateMaschine = playerStateMaschine;
        }

        public void Spawn()
        {
            _playerStateMaschine.SetState(_playerStateMaschine.GetAliveState());
        }

        public void TakeDamage()
        {
            Debug.Log("Cannot take more damage, player is already dead!");
        }

        public void Die()
        {
            Debug.Log("Player is already dead!");
        }
    }
}
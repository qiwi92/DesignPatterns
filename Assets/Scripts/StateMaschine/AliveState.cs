using UnityEngine;

namespace StateMaschine
{
    public class AliveState : IPlayerState
    {
        private readonly PlayerStateMaschine _playerStateMaschine;

        public AliveState(PlayerStateMaschine playerStateMaschine)
        {
            _playerStateMaschine = playerStateMaschine;
        }

        public void Spawn()
        {
            Debug.Log("Player is already alive!");
        }

        public void TakeDamage()
        {
            Debug.Log("Player took damage!");
            _playerStateMaschine.SetState(_playerStateMaschine.GetAliveState());
        }

        public void Die()
        {
            _playerStateMaschine.SetState(_playerStateMaschine.GetDeadState());
        }
    }
}
using UnityEngine;

namespace StateMaschine
{
    public class PlayerStateMaschine : IPlayerState
    {
        private IPlayerState _playerState;
        private readonly DeadState _deadState;
        private readonly AliveState _aliveState;

        private Player _player;

        public PlayerStateMaschine(Player player)
        {
            _player = player;
            _deadState = new DeadState(this, player);
            _aliveState = new AliveState(this, player);
            
            _playerState = _aliveState;

        }

        public void Spawn()
        {
            Debug.Log("Player has Respawned");
            _playerState.Spawn();
        }

        public void TakeDamage(int dmg)
        {
            _playerState.TakeDamage(dmg);
        }

        public void Die()
        {
            Debug.Log("Player is dead");
            _playerState.Die();
        }

        public void SetState(IPlayerState state)
        {
            _playerState = state;
        }

        public DeadState GetDeadState()
        {
            return _deadState;
        }

        public AliveState GetAliveState()
        {
            return _aliveState;
        }


    }
}
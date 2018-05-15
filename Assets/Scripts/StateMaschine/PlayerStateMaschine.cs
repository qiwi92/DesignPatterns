namespace StateMaschine
{
    public class PlayerStateMaschine : IPlayerState
    {
        private IPlayerState _playerState;
        private readonly DeadState _deadState;
        private readonly AliveState _aliveState;

        public PlayerStateMaschine()
        {
            _deadState = new DeadState(this);
            _aliveState = new AliveState(this);
            
            _playerState = _aliveState;

        }

        public void Spawn()
        {
            _playerState.Spawn();
        }

        public void TakeDamage()
        {
            _playerState.TakeDamage();
        }

        public void Die()
        {
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
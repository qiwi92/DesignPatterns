namespace StateMaschine
{
    public interface IPlayerState
    {
        void Spawn();
        void TakeDamage();
        void Die();
    }
}
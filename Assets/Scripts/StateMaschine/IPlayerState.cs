namespace StateMaschine
{
    public interface IPlayerState
    {
        void Spawn();
        void TakeDamage(int dmg);
        void Die();
    }
}
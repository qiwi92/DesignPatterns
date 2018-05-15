namespace StateMaschine
{
    public class Player
    {
        public int HitPoints { get; private set; }
        private readonly PlayerStateMaschine _playerStateMaschine;

        public Player()
        {
            RefillHp();

            _playerStateMaschine = new PlayerStateMaschine();
        }

        public void TakeDamage(int dmg)
        {
            if (dmg < 0)
            {
                return;
            }

            if (HitPoints - dmg <= 0)
            {
                HitPoints = 0;
                _playerStateMaschine.Die();
                return;
            }

            _playerStateMaschine.TakeDamage();
            HitPoints -= dmg;
        }

        public void RefillHp()
        {
            HitPoints = 100;
        }
    }
}
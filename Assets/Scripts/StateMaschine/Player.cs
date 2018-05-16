using System;

namespace StateMaschine
{
    public class Player
    {
        public int HitPoints { get; private set; }
        private readonly PlayerStateMaschine _playerStateMaschine;

        public Player()
        {
            RefillHp();

            _playerStateMaschine = new PlayerStateMaschine(this);
        }

        public bool TakeDamage(int dmg)
        {
            if (dmg < 0)
            {
                throw new ArgumentException();
            }

            if (HitPoints - dmg <= 0)
            {
                HitPoints = 0;
                return false;
            }

            HitPoints -= dmg;
            return true;
        }

        public void RefillHp()
        {
            HitPoints = 100;
        }
    }
}
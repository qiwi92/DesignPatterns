using UnityEngine;

namespace StateMaschine
{
    public class PlayerStateView : MonoBehaviour
    {
        private Player _player;

        private void Start()
        {
            _player = new Player();

            _player.TakeDamage(10);
            _player.TakeDamage(20);
            _player.TakeDamage(100);
        }
    }
}
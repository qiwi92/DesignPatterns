using System;
using Assets.Scripts;
using UnityEngine;
using DG.Tweening;

namespace CommandPattern
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerModel _playerModel;

        public void Setup(PlayerModel playerModel)
        {
            _playerModel = playerModel;

            _playerModel.Position.Subscribe(() =>
            {
                transform.DOKill();
                Move(_playerModel.Position.Value);
                Rotate(_playerModel.CurentDirection.Value);
            });

            _playerModel.CurentDirection.Subscribe(() =>
            {
                transform.DOKill();
                Rotate(_playerModel.CurentDirection.Value);
            });
        }

        private void Move(Vector2 position)
        {
            transform.DOMove(position, 0.2f);
        }

        private void Rotate(Direction direction)
        {
            var rotation = 0;

            switch (direction)
            {
                case Direction.None:
                    rotation = 0;
                    break;
                case Direction.Up:
                    rotation = 0;
                    break;
                case Direction.Right:
                    rotation = -90;
                    break;
                case Direction.Down:
                    rotation = 180;
                    break; ;
                case Direction.Left:
                    rotation = 90;
                    break;
            }

            transform.DORotate(Vector3.forward * rotation, 0.1f);
        }
    }
}
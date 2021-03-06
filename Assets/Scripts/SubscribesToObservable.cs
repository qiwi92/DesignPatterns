﻿using UnityEngine;

namespace Assets.Scripts
{
    public class SubscribesToObservable : MonoBehaviour
    {
        private HoldsObservable _hasObservable;

        private Observer<int> _someNumber;

        private void Start()
        {
            _someNumber = new Observer<int>();

            _hasObservable = new HoldsObservable();

            _hasObservable.SomeObservable.AddObserver(_someNumber);

            _someNumber.Subscribe(() =>
            {
                Debug.Log("Value: " + _someNumber.Value);
            });

            

            _hasObservable.SomeObservable.Value = 2;

            _hasObservable.SomeObservable.Value = 4;

            _hasObservable.SomeObservable.RemoveObserver(_someNumber);

            _hasObservable.SomeObservable.Value = 0;

        }
    }
}
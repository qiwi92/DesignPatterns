using UnityEngine;

namespace Assets.Scripts
{
    public class ExampleReactive : MonoBehaviour
    {
        private ReactiveProperty<int> _number = new ReactiveProperty<int>();

        private int _otherNumber = 0;
        

        private void Start()
        {
            //_number.Subscribe(() => _otherNumber = _number.Value );


            _number.Value = 3;
            Debug.Log(_otherNumber);

            _number.Value = 4;
            Debug.Log(_otherNumber);

            _number.UnubscribeAll();
            _number.Value = 30;
            Debug.Log(_otherNumber);
        }

    }
}
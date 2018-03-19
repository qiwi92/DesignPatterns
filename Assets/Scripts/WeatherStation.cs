using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class WeatherStation : MonoBehaviour
    {
        private Data _data;
        public CurrentConditionsDisplay CurrentDisplay;

        private float _timer = 0;

        private int _counter = 0;

        private void Start()
        {
            
            _data = new Data();
            CurrentDisplay.SetUp(_data);
        }

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer > 1)
            {
                _counter++;
                _data.SetMeasurements(_counter, 2 * _counter, _counter * 0.5f);
                _timer = 0;              
            }
        }
    }
}
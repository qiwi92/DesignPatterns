using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class CurrentConditionsDisplay : MonoBehaviour, IObserver, IDisplayElement
    {
        public Text TemperatureText;
        public Text HumidityText;

        private float _temperature;
        private float _humidity;
        private ISubject _data;

        public Button SubscribeButton;
        public Button UnsubscribeButton;

        private void Start()
        {
            SubscribeButton.onClick.AddListener(Subscribe);
            UnsubscribeButton.onClick.AddListener(Dispose);
        }

        public void SetUp(ISubject data)
        {
            _data = data;
            _data.RegisterObserver(this);
        }

        private void Subscribe()
        {
            _data.RegisterObserver(this);
        }

        private void Dispose()
        {
            _data.RemoveObserver(this);
        }

        public void UpdateValues(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            TemperatureText.text = "Temperature: " + _temperature.ToString("0.0");
            HumidityText.text = "Humidity: " + _humidity.ToString("0.0");
        }
    }
}
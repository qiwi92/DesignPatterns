namespace Assets.Scripts
{
    public interface IObserver
    {
        void UpdateValues(float temperature, float humidity, float pressure);
    }
}
namespace observer_pattern.interfaces
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
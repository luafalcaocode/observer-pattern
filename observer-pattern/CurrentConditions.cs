using observer_pattern.Interfaces;
using System;

namespace observer_pattern
{
    public class CurrentConditions : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;
        
        public CurrentConditions(ISubject weatherData) {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display() {
            Console.WriteLine($"Condições atuais: {this.temperature}F graus e {this.humidity}% de humidade");
        }
    }
}
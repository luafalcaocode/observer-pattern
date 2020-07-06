using observer_pattern.interfaces;
using System;
using System.Collections.Generic;

namespace observer_pattern
{
    public class WeatherData : ISubject
    {
        private IList<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        
        public WeatherData() {
            this.observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer) {
            this.observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer) {
            this.observers.Remove(observer);
        }
        public void NotifyObservers() {
            foreach(var o in this.observers) {
                o.Update(this.temperature, this.humidity, this.pressure);
            }
        }
        public void MeasurementsChanged() {
            NotifyObservers();
        }
        public void SetMeasurementsChanged(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        
    }
}
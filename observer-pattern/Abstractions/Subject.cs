using System.Collections.Generic;

namespace observer_pattern.Abstractions
{
    public abstract class Subject
    {
        public abstract int Hour { get; set; }
        public abstract int Minutes { get; set; }
        public abstract int Seconds { get; set; }
        private IList<Observer> _observers = new List<Observer>();

        public void Attach(Observer o)
        {
            this._observers.Add(o);
        }

        public void Detach(Observer o)
        {
            this._observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var o in this._observers)
            {
                o.Update(this);
            }
        }
    }
}
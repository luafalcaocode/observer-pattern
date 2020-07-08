using observer_pattern.Abstractions;
using observer_pattern.Interfaces;
using System;

namespace observer_pattern
{
    public class AnalogClock : Observer, IDraw
    {
        private Subject _subject;
        public AnalogClock(Subject subject) {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update(Subject subject) {
            if (subject == this._subject) {
                Draw(subject.Hour, subject.Minutes, subject.Seconds);
            }
        }

        public void Draw(int hour, int minutes, int seconds) {
            Console.WriteLine($"Hora atual pelo relógio analógico: {hour.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
        }
    }
}
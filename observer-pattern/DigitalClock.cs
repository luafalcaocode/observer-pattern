using observer_pattern.Abstractions;
using observer_pattern.Interfaces;
using System;

namespace observer_pattern
{
    public class DigitalClock : Observer, IDraw
    {
        private Subject _clockTimer;

        public DigitalClock(Subject subject) {
            this._clockTimer = subject;
            this._clockTimer.Attach(this);
        }

        public override void Update(Subject subject) {
            if (subject == _clockTimer) {
                Draw(subject.Hour, subject.Minutes, subject.Seconds);
            }
        }

        public void Draw(int hour, int minutes, int seconds) {
            Console.WriteLine($"Hora atual pelo relógio digital: {hour.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
        }
    }
}
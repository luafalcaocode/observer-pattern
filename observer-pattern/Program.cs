using observer_pattern.Abstractions;
using System;
using System.Threading;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTimer timer = new ClockTimer();
            DigitalClock digitalClock = new DigitalClock(timer);
            AnalogClock analogClock = new AnalogClock(timer);

            for (var times = 0; times < 3; times++)
            {
                timer.Tick();
                Thread.Sleep(2000);
            }
        }
    }
}

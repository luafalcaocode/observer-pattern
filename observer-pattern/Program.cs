using observer_pattern.Abstractions;
using System;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockTimer timer = new ClockTimer();
            DigitalClock digitalClock = new DigitalClock(timer);

            for (var times = 0; times < 9; times++)
            {
                timer.Tick();
            }
        }
    }
}

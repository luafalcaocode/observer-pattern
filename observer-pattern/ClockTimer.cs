using observer_pattern.Abstractions;
using observer_pattern.Interfaces;
using System;

namespace observer_pattern
{
    public class ClockTimer : Subject, ITimer
    {
         private int _hour;
         private int _minutes;
         private int _seconds;

         public override int Hour { get => this._hour; set => this._hour = value; }
         public override int Minutes {get => this._minutes; set => this._minutes = value; }
         public override int Seconds {get => this._seconds; set => this._seconds = value; }

         public void Tick() {
             Hour = DateTime.Now.Hour;
             Minutes = DateTime.Now.Minute;
             Seconds = DateTime.Now.Second;

             base.Notify();
         }
    }
}
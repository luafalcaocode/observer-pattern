namespace observer_pattern.Abstractions
{
    public abstract class Observer
    {
        private Subject _subject;

        public abstract void Update(Subject theChangedSubject);
    }
}
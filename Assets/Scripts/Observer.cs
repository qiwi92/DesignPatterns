using System;

namespace Assets.Scripts
{
    public class Observer<T>
    {
        public T Value;

        private Action _action;

        public void Subscribe(Action action)
        {
            _action = action;
        }

        public void NotifyChange()
        {
            _action.Invoke();
        }
    }
}
using System;
using System.Linq;
using Boo.Lang;

namespace Assets.Scripts
{
    public class ReactiveProperty<T>
    {
        public readonly List<Observer> Observers = new List<Observer>();

        private T _value;

        public T Value
        {
            get { return _value; }
            set { SetValue(value); }
        }

        private void SetValue(T value)
        {
            _value = value;
            NotifyAllObservers();
        }

        private void NotifyAllObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Action.Invoke();
            }
        }

        
    }

    public class Observer
    {
        public Action Action;

        public Observer(Action action)
        {
            Action = action;
        }
    }


    public static class ReactiveExtension
    {
        public static void Subscribe<T>(this ReactiveProperty<T> reactiveProperty, Action action)
        {
            reactiveProperty.Observers.Add(new Observer(action));
        }

        public static void UnubscribeAll<T>(this ReactiveProperty<T> reactiveProperty)
        {
            reactiveProperty.Observers.Clear();
        }
    }

    public class Disposer
    {
        public int Id;

        public Disposer(int id)
        {
            Id = id;
        }
    }
}
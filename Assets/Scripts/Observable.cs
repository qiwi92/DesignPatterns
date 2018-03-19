using System;
using System.Diagnostics;
using Boo.Lang;
using JetBrains.Annotations;

namespace Assets.Scripts
{
    public class Observable<T>
    {
        private readonly List<Observer<T>> _observers;

        private T _value;

        public T Value
        {
            get { return _value; }
            set { SetValue(value);}
        }

        private void SetValue(T value)
        {
            _value = value;
            NotifyAllObservers();
        }

        public Observable()
        {
            _observers = new List<Observer<T>>();
        }

        public void AddObserver(Observer<T> observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer<T> observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Value = _value;
            }
        }     
    }   
}
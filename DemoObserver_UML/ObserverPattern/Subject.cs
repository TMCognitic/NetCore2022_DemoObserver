﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver_UML.ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> _observers;

        public Subject()
        {
            _observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer observer in _observers)
                observer.Update(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver_UML.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        private Action<ISubject>? _handler;

        public void Attach(Action<ISubject> action)
        {
            _handler += action;            
        }

        public void Detach(Action<ISubject> action)
        {
            _handler -= action;
        }

        protected void Notify()
        {
            _handler?.Invoke(this);
        }
    }
}

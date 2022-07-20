using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver_UML.ObserverPattern
{
    public abstract class Subject : ISubject
    {
        public event Action<ISubject>? Handler;

        protected void Notify()
        {
            Handler?.Invoke(this);
        }
    }
}

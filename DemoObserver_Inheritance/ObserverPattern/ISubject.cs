namespace DemoObserver_UML.ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}
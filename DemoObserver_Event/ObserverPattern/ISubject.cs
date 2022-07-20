namespace DemoObserver_UML.ObserverPattern
{
    public interface ISubject
    {
        event Action<ISubject>? Handler;
    }
}
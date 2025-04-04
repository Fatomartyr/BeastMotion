namespace BeastMotionApp.Models.ObserverPattern;

public interface IObservable
{
    void NotifyObservers(IAction action);
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
}
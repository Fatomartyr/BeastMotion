namespace BeastMotionApp.Models;

public interface IObservable
{
    void NotifyObservers(IAction action);
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
}
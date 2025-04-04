using System.Collections.Generic;
using BeastMotionApp.Models.ObserverPattern;

namespace BeastMotionApp.Models.Dog;

public class BarkObservable : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();

    public void NotifyObservers(IAction action)
    {
        foreach (var observer in _observers)
        {
            observer.Notify(action);
        }
    }

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }
}
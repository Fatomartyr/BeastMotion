namespace BeastMotionApp.Models.ObserverPattern;

public interface IObserver
{
    void Notify(IAction action);
}
namespace BeastMotionApp.Models;

public interface IObserver
{
    void Notify(IAction action);
}
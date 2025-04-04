namespace BeastMotionApp.Models;

public class ActionObserver : IObserver
{
    private string _name;
    
    public ActionObserver(string name)
    {
        _name = name;
    }
    
    public void Notify(IAction action)
    {
        // TODO: How to link with MW
    }
}
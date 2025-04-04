using BeastMotionApp.Models.ObserverPattern;

namespace BeastMotionApp.Models.Panther;

public class Roar : IAction
{
    public string Title { get; }
    public string Content { get; }
    
    public Roar ()
    {
        Title = "Roar";
        Content = "The Pather roars";
    }
    
}
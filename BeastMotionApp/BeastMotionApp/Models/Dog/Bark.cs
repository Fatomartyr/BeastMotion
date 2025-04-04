using BeastMotionApp.Models.ObserverPattern;

namespace BeastMotionApp.Models.Dog;

public class Bark : IAction
{
    public string Title { get; }
    public string Content { get; }

    public Bark()
    {
        Title = "Bark";
        Content = "The Dog barks";
    }
}
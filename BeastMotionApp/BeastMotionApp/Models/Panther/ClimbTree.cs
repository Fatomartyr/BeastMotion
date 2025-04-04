using BeastMotionApp.Models.ObserverPattern;

namespace BeastMotionApp.Models.Panther;

public class ClimbTree : IAction
{
    public string Title { get; }
    public string Content { get; }
    public ClimbTree ()
    {
        Title = "Climb Tree";
        Content = "The Pather climbs the tree";
    }
}   
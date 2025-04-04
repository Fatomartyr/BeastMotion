namespace BeastMotionApp.Models;

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
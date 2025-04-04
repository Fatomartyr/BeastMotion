namespace BeastMotionApp.Models;

public abstract class LivingCreature
{
    public double Speed { get; set; }
    public abstract void Move();
    public abstract void Stop();
    
}
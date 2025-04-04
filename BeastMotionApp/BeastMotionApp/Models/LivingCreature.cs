namespace BeastMotionApp.Models;

abstract class LivingCreature
{
    public double Speed { get; set; }
    public abstract void Move();
    public abstract void Stop();
    
}
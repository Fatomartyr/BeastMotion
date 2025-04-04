namespace BeastMotionApp.Models;

public abstract class LivingCreature
{
    public double Speed { get; set; }
    public void InitializeSpeed(double initialSpeed)
    {
        Speed = initialSpeed;
    }
    public abstract void Move();
    public abstract void Stop();
    
}
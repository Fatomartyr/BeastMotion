using System;

namespace BeastMotionApp.Models.Dog;

public class Dog : LivingCreature
{
    public Dog()
    {
    }
    
    public override void Move()
    {
        Speed = Math.Min(Speed + 6, 44);
    }

    public override void Stop()
    {
        Speed = Math.Max(Speed - 6, 0);
    }
    
}
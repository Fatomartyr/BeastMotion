using System;
namespace BeastMotionApp.Models.Panther;

public class Panther : LivingCreature
{
    public Panther()
    {
    }
    
    public override void Move()
    {
        Speed = Math.Min(Speed + 10, 60);
    }
    
    public override void Stop()
    {
        Speed = Math.Max(Speed - 10, 0);
    }
}
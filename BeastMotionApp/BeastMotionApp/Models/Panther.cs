using System;
namespace BeastMotionApp.Models;

public class Panther : LivingCreature
{
    
    public override void Move()
    {
        Speed = Math.Min(Speed + 10, 60);
    }
    

    public override void Stop()
    {
        Speed = Math.Max(Speed - 10, 0);
    }
    
    
    
}
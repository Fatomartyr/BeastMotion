using System;

namespace BeastMotionApp.Models.Turtle;

public class Turtle : LivingCreature
{
    public Turtle()
    {
    }

    public override void Move()
    {
        Speed = Math.Min(Speed + 2, 9);
    }

    public override void Stop()
    {
        Speed = Math.Max(Speed - 2, 0);
    }
}
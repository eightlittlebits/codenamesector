using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNameSector
{
    public class Vessel
    {
        public Vector2 Position { get; private set; }
        public Vector2 Bearing { get; protected set; }
        public int Speed { get; protected set; }

        public Vessel(Vector2 position, Vector2 bearing, int speed)
        {
            Position = position;
            Bearing = bearing;
            Speed = speed;
        }

        public void Move()
        {
            Position = Position + Bearing * Speed;
        }
    }
}

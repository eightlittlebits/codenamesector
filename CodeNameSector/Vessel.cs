using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeNameSector
{
    public class Vessel
    {
        public Vector2 Position { get; set; }
        public Vector2 Heading { get; set; }
        public int Speed { get; set; }

        public Vessel(Vector2 position, Vector2 heading, int speed)
        {
            Position = position;
            Heading = heading;
            Speed = speed;
        }

        public Vector2 ProjectedMove()
        {
            return Position + Heading * Speed;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodeNameSector
{
    public class PlayerShip : Vessel
    {
        public PlayerShip(Vector2 position, Vector2 bearing, int speed, Color colour) 
            : base(position, bearing, speed)
        {
            Colour = colour;
        }

        public Color Colour { get; private set; }
        public Vector2 AimDirection { get; set; }
        public int AimDepth { get; set; }
    }
}

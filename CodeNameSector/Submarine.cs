using System;

namespace CodeNameSector
{
    public class Submarine : Vessel
    {
        private int _depth;

        public int Depth
        {
            get { return _depth; }
            set 
            {
                if (value < 1 || value > 3)
                {
                    throw new ArgumentOutOfRangeException("value", value, "depth must be between 0 and 7 inclusive");
                }

                _depth = value; 
            }
        }

        public Submarine(Vector2 position, Vector2 heading, int depth)
            : base(position, heading, 1)
        {
            if (depth < 1 || depth > 3)
            {
                throw new ArgumentOutOfRangeException("depth", depth, "depth must be between 0 and 7 inclusive");
            }

            _depth = depth;
        }
    }
}
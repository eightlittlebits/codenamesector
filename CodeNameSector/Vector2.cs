using System;

namespace CodeNameSector
{
    public struct Vector2
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Vector2(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2 operator *(Vector2 v1, int i)
        {
            return new Vector2(v1.X * i, v1.Y * i);
        }

        public static int ChebyshevDistance(Vector2 v1, Vector2 v2)
        {
            var distance = v1 - v2;

            return Math.Max(Math.Abs(distance.X), Math.Abs(distance.Y));
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}

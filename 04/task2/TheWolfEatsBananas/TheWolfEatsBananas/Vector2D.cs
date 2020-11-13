namespace TheWolvesAndBananas
{
    public class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Add(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override bool Equals(object obj)
        {
            return (obj is Vector2D) && X == ((Vector2D)obj).X && Y == ((Vector2D)obj).Y;
        }

        public bool Equals(Vector2D v)
        {
            return !(v is null) && X == v.X && Y == v.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode();
        }

        public static bool operator ==(Vector2D v1, Vector2D v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vector2D v1, Vector2D v2)
        {
            return !v1.Equals(v2);
        }

        public static Vector2D operator +(Vector2D v)
        {

            return v;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {

            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2D operator -(Vector2D v)
        {
            return new Vector2D(-v.X, -v.Y);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2D operator *(Vector2D v, int i)
        {
            return new Vector2D(v.X * i, v.Y * i);
        }

    }
}

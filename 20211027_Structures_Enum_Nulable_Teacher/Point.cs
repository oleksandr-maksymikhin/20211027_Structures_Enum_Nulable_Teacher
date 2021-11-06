using System;

namespace Structs
{
    public struct Point:IComparable
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        
        public int X
        {
            get => _x;
            set => _x = value;
        }
        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public static bool operator ==(Point l, Point r)
        {
            return l._x == r._x && l._y == r._y;
        }
        public static bool operator !=(Point l, Point r)
        {
            return !(l == r);
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }

        public int CompareTo(object obj)
        {
            Point tmp = (Point) obj;
            return X - tmp.X;
        }
    }
}
using System;

namespace Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Color { get; set; }

        public Shape(int x, int y, string color) {
            this.X = x;
            this.Y = y;
            this.Color = color;
        }

        public Shape(Shape source) :
            this(source.X, source.Y, source.Color) { }

        public abstract Shape Clone();

        public override string ToString()
        {
            return $"X:{this.X} Y:{this.Y} Color:{this.Color}";
        }
    }
}
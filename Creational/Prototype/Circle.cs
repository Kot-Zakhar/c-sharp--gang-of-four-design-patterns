using System;

namespace Prototype {
    public class Circle : Shape {
        public int Radius { get; set; }

        public Circle(int x, int y, string color, int radius) : base(x, y, color) {
            this.Radius = radius;
        }

        public Circle(Circle source) : base(source) {
            this.Radius = source.Radius;
        }

        public override Circle Clone() {
            return new Circle(this);
        }

        public override string ToString()
        {
            return base.ToString() + $" radius:{this.Radius}";
        }
    }
}
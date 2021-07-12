using System;

namespace Prototype {
    public class Rectangle : Shape {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color) {
            this.Width = width;
            this.Height = height;
        }

        public Rectangle(Rectangle source) : base(source) {
            this.Width = source.Width;
            this.Height = source.Height;
        }

        public override Rectangle Clone() {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            return base.ToString() + $" width:{this.Width} height:{this.Height}";
        }
    }
}
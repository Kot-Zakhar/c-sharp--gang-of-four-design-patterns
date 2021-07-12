using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {

        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            Circle circle = new Circle(0, 0, "White", 10);
            shapes.Add(circle);

            Circle clonedCircle = circle.Clone();
            clonedCircle.Color = "Black";
            shapes.Add(clonedCircle);

            Rectangle rect = new Rectangle(0, 10, "Red", 10, 15);
            shapes.Add(rect);

            var clones = new List<Shape>();
            foreach (var shape in shapes)
                clones.Add(shape.Clone());

            for (int i = 0; i < shapes.Count; i++) {
                Shape shape = shapes[i];
                Shape clone = clones[i];
                Console.WriteLine("Comparing shape with it`s clone:\n{0}\n{1}\n{2}", shape, clone, shape == clone ? "Single ref" : "Different refs");
            }
        }
    }
}

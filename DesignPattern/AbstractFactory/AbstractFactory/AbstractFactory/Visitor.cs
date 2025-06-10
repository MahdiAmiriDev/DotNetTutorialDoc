using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IShape<T>
    {
        void AcceptVisitor(IShapeVisitor<T> visitor);
    }

    interface IShapeVisitor<T>
    {
        T Visit(Rectangle rectangle);

        T Visit(Circle circle);
    }

    class AreaCalculator : IShapeVisitor<int>
    {
        public int Visit(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public int Visit(Circle circle)
        {
            return (int)Math.PI * (circle.Radius * circle.Radius);
        }
    }

    class Rectangle : IShape<int>
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void AcceptVisitor(IShapeVisitor<int> visitor)
        {
            Console.WriteLine(visitor.Visit(this));
        }
    }

    class Circle : IShape<int>
    {
        public int Radius { get; set; }
        public void AcceptVisitor(IShapeVisitor<int> visitor)
        {
            Console.WriteLine(visitor.Visit(this));
        }
    }
}

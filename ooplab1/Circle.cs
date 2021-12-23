using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius=radius;
        }
        public override double GetArea()
        {
            return _radius*_radius*3.14;
        }

        public override double GetPerimeter()
        {
            return 2 * _radius * 3.14;
        }

        public override string ToString()
        {
            return "This is a Circle with Radius " + _radius + " . Area is " + GetArea() + " And Perimeter is " + GetPerimeter();
        }
    }
}

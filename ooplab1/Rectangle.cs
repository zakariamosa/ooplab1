using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1
{
    public class Rectangle : Shape
    {
        private double _width { get; set; }
        private double _height { get; set; }
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public Rectangle(double widthsameheight)
        {
            _width=widthsameheight;
            _height=widthsameheight;
        }
        public override double GetArea()
        {
            return _width * _height;
        }

        public override double GetPerimeter()
        {
            return 2 * (_height + _width);  
        }

        public override string ToString()
        {
            return "This is a Rectangle with height "+ _height + " and width " + _width + " . Area is " + GetArea()+ " And Perimeter is " + GetPerimeter();
        }
    }
}

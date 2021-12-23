using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab1
{
    public class Square : Shape
    {
        private double _sidelength;
        public double SideLength 
        {
            get
            {
                return _sidelength;
            }
            set
            {
                _sidelength = value;
            } 
        }

        
        public Square()
        {
            _sidelength = SideLength;
        }
        public Square(double sidelength)
        {
            _sidelength=sidelength;
        }
        public override double GetArea()
        {
            return _sidelength * _sidelength;
        }

        public override double GetPerimeter()
        {
            return _sidelength * 4;
        }

        public override string ToString()
        {
            return "This is a Square with side length " + _sidelength + " . Area is " + GetArea() + " And Perimeter is " + GetPerimeter();
        }
    }
}

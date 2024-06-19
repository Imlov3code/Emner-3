using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference_LeviAndAneel {
   
    public class Rectangle : Shape {
        public double Length { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }

        public Rectangle(double length, double width, string name = "Rectangle")
        {
            Length = length;
            Width = width;
            Name = name;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetCircumference()
        {
            return (Length + Width) * 2;
        }
    }
}

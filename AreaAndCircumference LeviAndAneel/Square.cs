using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference_LeviAndAneel {
    public class Square : Shape {
        public double Side { get; set; }
        public string Name { get; set; }

        public Square(double side, string name = "Square")
        {
            Side = side;
            Name = name;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetCircumference()
        {
            return Side * 4;
        }
    }
}

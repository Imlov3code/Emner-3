using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference_LeviAndAneel {
    public class Triangle : Shape {
        public double Width { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public string Name { get; set; }

        public Triangle(double width, double height, double sideA, double sideB, double sideC, string name = "Trangle")
        {
            Width = width;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Name = name;
        }

        public override double GetArea()
        {
            return (Width * Height * 0.5);
        }

        public override double GetCircumference()
        {
            return SideA + SideB + SideC;
        }
    }
}

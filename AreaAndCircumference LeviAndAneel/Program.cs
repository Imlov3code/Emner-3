namespace AreaAndCircumference_LeviAndAneel {
    internal class Program {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Triangle(3, 4, 3, 4, 5),
                new Rectangle(4, 5),
                new Square(4)
            };

            /*for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].
            }*/

            /*var trangle = new Triangle(3, 4, 3, 4, 5);
            Console.WriteLine($"{trangle.Name}");*/

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name} is {shape.GetArea()}");
                Console.WriteLine($"Circumference of {shape.GetType().Name} is {shape.GetCircumference()}");
            }
        }
    }
}
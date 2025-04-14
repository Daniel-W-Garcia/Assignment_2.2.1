

using Assignment_2._2._1;

Square square = new Square();
CircleShape circle = new CircleShape();

square.PrintArea();

Console.WriteLine("Please enter the radius of the circle: ");
circle.Radius = double.Parse(Console.ReadLine());
circle.CalculateArea(circle.Radius);

Console.WriteLine($"The area of a circle with a radius of {circle.Radius} is {circle.Area} ");


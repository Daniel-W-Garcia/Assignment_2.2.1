

using Assignment_2._2._1;

Square square = new Square();
CircleShape circle = new CircleShape();

Console.WriteLine($""""
                   Would you like to calculate the area of a circle or a square?
                   Enter 'C' for circle or 'S' for square:
                   """");
string userInput = Console.ReadLine().ToLower();

switch (userInput)
{
    case "c":
        Console.WriteLine("Please enter the radius of the circle: ");
        circle.Radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"""
                            The area of a circle with a radius of {circle.Radius} is:
                            {circle.CalculateArea(circle.Radius)};
                           """);
        break;
    case "s":
        square.PrintArea();
        break;
        
}






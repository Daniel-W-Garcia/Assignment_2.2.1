namespace Assignment_2._2._1;

public class Square : Shape
{
    float side;
    float area;
    

    public void PrintArea()
    {
        Console.WriteLine($"Please enter the side of the square: "); 
        side = float.Parse(Console.ReadLine());
        CalculateArea();
        
        Console.WriteLine($"The area of a square with a side length of {side} is {area} ");
    }

    private void CalculateArea()
    {
        area = side * side;
    }
}
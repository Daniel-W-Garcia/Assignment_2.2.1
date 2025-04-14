namespace Assignment_2._2._1;

public class Square : Shape
{
    
    public void PrintArea()
    {
        Console.WriteLine($"Please enter the side of the square: "); 
        float side = float.Parse(Console.ReadLine());
        float area = CalculateArea(side);
        
        Console.WriteLine($"The area of a square with a side length of {side} is {area} ");
    }

    private float CalculateArea(float side)
    {
        float area = side * side;
        return area;
    }
}
namespace Assignment_2._2._1;

public class CircleShape : Shape
{
    public double Radius { get; set; }
    public double Area { get; set; }

    public double CalculateArea(double radius)
    {
        return radius * radius * Math.PI;
    }
}
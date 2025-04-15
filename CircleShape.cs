namespace Assignment_2._2._1;

public class CircleShape : Shape
{
    public double Radius { get; set; }
    public double Area { get; set; }

    public double CalculateArea(double radius)
    {
        Radius = radius;
        Area = radius * radius * Math.PI;
        return Area;
    }
}
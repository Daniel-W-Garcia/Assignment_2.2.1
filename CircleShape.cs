namespace Assignment_2._2._1;

public class CircleShape : Shape
{
    public double Radius { get; set; }
    public double Area { get; set; }

    public void CalculateArea(double radius)
    {
        Area = radius * radius * Math.PI;
    }
}
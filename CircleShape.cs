namespace Assignment_2._2._1;

public class CircleShape : Shape
{
    private float radius { get; set; }
    private float area { get; set; }

    private void CalculateArea(float radius)
    {
        double circleArea = radius * radius * Math.PI;
    }
}
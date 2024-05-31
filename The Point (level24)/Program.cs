
Point point = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point.getxPoint()}, {point.getyPoint()})");
Console.WriteLine($"({point2.getxPoint()}, {point2.getyPoint()})");

public class Point
{
    private int X, Y;

    public Point(int x, int y)
    {
        X = x; 
        Y = y;
    }

    public int getxPoint()
    {
        return X;
    }
    public int getyPoint()
    {
        return Y;
    }
}


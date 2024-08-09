namespace Assignment_1.Shapes;

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("rectangle draw");
    }

    public override void Move(int x, int y)
    {
        Console.WriteLine($"rectangle move ({x}, {y})");
    }
}
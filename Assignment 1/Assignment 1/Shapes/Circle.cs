namespace Assignment_1.Shapes;

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("circle draw");
    }

    public override void Move(int x, int y)
    {
        Console.WriteLine($"circle move ({x}, {y})");
    }
}
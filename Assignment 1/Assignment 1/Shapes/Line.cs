namespace Assignment_1.Shapes;

public class Line : Shape
{
    public override void Draw()
    {
        Console.WriteLine("drawing line");
    }

    public override void Move(int x, int y)
    {
        Console.WriteLine($"moving line to ({x}, {y})");
    }
}
using Assignment_1.Shapes;

namespace Assignment_1;

public class CompositeShape : Shape
{
    private List<Shape> _shapes = new List<Shape>();

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    public void RemoveShape(Shape shape)
    {
        _shapes.Remove(shape);
    }

    public override void Draw()
    {
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        foreach (var shape in _shapes)
        {
            shape.Move(x, y);
        }
    }
}

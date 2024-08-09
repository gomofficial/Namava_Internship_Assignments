using Assignment_1.Shapes;

namespace Assignment_1;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("inheritance:");
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();
        Shape line = new Line();

        circle.Draw();
        rectangle.Draw();
        line.Draw();

        circle.Move(10, 20);
        rectangle.Move(30, 40);
        line.Move(50, 60); 
        
        Console.WriteLine("Composite:");
        CompositeShape compositeShape = new CompositeShape();
        compositeShape.AddShape(new Circle());
        compositeShape.AddShape(new Rectangle());

        compositeShape.Draw();
        compositeShape.Move(100, 200);

        Console.WriteLine("new shape added to composites:");
        compositeShape.AddShape(new Line());
        compositeShape.Draw();
        compositeShape.Move(300, 400);
    }
}


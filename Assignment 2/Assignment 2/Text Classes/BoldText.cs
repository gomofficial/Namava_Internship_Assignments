using Assignment_2.Interfaces;

namespace Assignment_2.Text_Classes;

public class BoldText : IText
{
    private IText _text;

    public BoldText(IText text)
    {
        _text = text;
    }

    public void Display()
    {
        Console.Write("**");
        _text.Display();
        Console.Write("**");
    }
}
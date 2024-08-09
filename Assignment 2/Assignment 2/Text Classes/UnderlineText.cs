using Assignment_2.Interfaces;

namespace Assignment_2.Text_Classes;

public class UnderlineText : IText
{
    private IText _text;

    public UnderlineText(IText text)
    {
        _text = text;
    }

    public void Display()
    {
        Console.Write("__");
        _text.Display();
        Console.Write("__");
    }
}
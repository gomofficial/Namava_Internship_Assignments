using Assignment_2.Interfaces;

namespace Assignment_2.Text_Classes;

public class ItalicText : IText
{
    private IText _text;

    public ItalicText(IText text)
    {
        _text = text;
    }

    public void Display()
    {
        Console.Write("_");
        _text.Display();
        Console.Write("_");
    }
}
using Assignment_2.Interfaces;

namespace Assignment_2.Text_Classes;

public class PlainText : IText
{
    private string _text;

    public PlainText(string text)
    {
        _text = text;
    }

    public void Display()
    {
        Console.Write(_text);
    }
}
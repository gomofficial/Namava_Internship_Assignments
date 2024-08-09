using Assignment_2.Interfaces;
 using Assignment_2.Text_Classes;
 
 namespace Assignment_2;
 
 
 public static class Program
 {
     public static void Main()
     {
         IText plainText = new PlainText("Hello, World!");
         Console.WriteLine();
         Console.WriteLine("Plain text:");
         plainText.Display();
 
         IText boldText = new BoldText(plainText);
         Console.WriteLine();
         Console.WriteLine("Bold text:");
         boldText.Display();
 
         IText italicText = new ItalicText(plainText);
         Console.WriteLine();
         Console.WriteLine("Italic text:");
         italicText.Display();
 
         IText underlineText = new UnderlineText(plainText);
         Console.WriteLine();
         Console.WriteLine("Underlined text:");
         underlineText.Display();
 
         IText boldItalicText = new BoldText(new ItalicText(plainText));
         Console.WriteLine();
         Console.WriteLine("Bold and italic text:");
         boldItalicText.Display();
 
         IText boldItalicUnderlineText = new BoldText(new ItalicText(new UnderlineText(plainText)));
         Console.WriteLine();
         Console.WriteLine("Bold, italic, and underlined text:");
         boldItalicUnderlineText.Display();
     }
 }
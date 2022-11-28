//принцип підстановки Лісков
using System;
class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

interface ISquare
{
    public int Side { get; set; }

    public int GetRectangleArea();
}
class Square : ISquare
{
    public int Side { get; set; }
    public int GetRectangleArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        Square square = new Square();
        rect.Width = 5;
        rect.Height = 10;
        square.Side = 5;
        Console.WriteLine(rect.GetRectangleArea());
        Console.WriteLine(square.GetRectangleArea());
        Console.ReadKey();
    }
}

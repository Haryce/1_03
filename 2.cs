class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    static void Main()
    {
        Rectangle rectangle = new Rectangle
        {
            Width = 5,
            Height = 10
        };
        System.Console.WriteLine($"Площадь: {rectangle.GetArea()}");
        System.Console.WriteLine($"Периметр: {rectangle.GetPerimeter()}");
    }
}
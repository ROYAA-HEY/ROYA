class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public string CalculateArea()
    {
        return "Rectangle area: " + (Width * Height);
    }

    public string CalculatePerimeter()
    {
        return "Rectangle perimeter: " + (2 * (Width + Height));
    }
}
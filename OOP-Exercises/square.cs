class Square
{
    public double Side { get; set; }

    public string CalculateArea()
    {
        return "Square area: " + (Side * Side);
    }

    public string CalculatePerimeter()
    {
        return "Square perimeter: " + (4 * Side);
    }
}
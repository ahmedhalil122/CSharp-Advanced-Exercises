namespace ClassBoxData.Models;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    private double Length
    {
        get => length;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            length = value;
        }
    }
    private double Width
    {
        get => width;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            width = value;
        }
    }
    private double Height
    {
        get => height;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            height = value;
        }
    }

    public double SurfaceArea()
         => 2 * Length * Width + LateralSurfaceArea();
    public double LateralSurfaceArea()
        => 2 * Length * Height + 2 * Width * Height;
    public double Volume()
        => Length * Width * Height;

}

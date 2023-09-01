using System;

public class Shape

{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Rectangle : Shape
{
    /// Private fields for width and height
    private int width;
    private int height;

     /// Public property for width
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// Public property for height
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

}

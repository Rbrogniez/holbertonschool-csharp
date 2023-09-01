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

    // Override the Area() method from the base class
    public override int Area()
    {
        return Width * Height;
    }

    // Override the ToString() method to provide a custom string representation
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

public class Square : Rectangle
{
    private int size;

    public int Size
    {
        get { return size; }
        set
        {
            if (size < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }

            /// Set the size, height, and width to the same value
            size = value;
            Width = value;
            Height = value;
        }
    }
}

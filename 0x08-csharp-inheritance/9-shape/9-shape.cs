using System;

/// <summary>Contains a method to calculate the area</summary>
class Shape
{
    /// <summary>Calculates the area</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Defines a rectangle and inherits from shape</summary>
class Rectangle : Shape
{
    // Width of rectangle.
    private int width;
    // Height of rectangle.
    private int height;

    /// <summary>Public property for width</summary>
    public int Width
    {
        get
        {
            return width;   
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
            
        }
    }
    /// <summary>Public property for Height</summary>
    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>Calculates area of rectangle</summary>
    public override int Area()
    {
        return width * height;
    }

    /// <summary>ToString override method</summary>
    public override string ToString()
    {
        return String.Format($"[Rectangle] {width} / {height}", width, height);
    }
}

/// <summary>Definition of class Square</summary>
class Square : Rectangle
{
    // Size of Square.
    private int size;

    /// <summary>Public proterty size</summary>
    public int Size
    {
        get
        {
            return size;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }

    /// <summary>ToString override method</summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
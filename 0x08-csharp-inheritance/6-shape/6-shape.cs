using System;

class Shape {
    /// <summary>
    /// Calculate the Area of a shape
    /// </summary>
    /// <returns>Int Value of the Area</returns>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape {
    private int width;
    private int height;
    // public int Width;

    public int Width {
        
        get { return width;}
        set { 
            if (value < 0 )
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height {
        get {return height}
        set { 
            if (value < 0 )
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
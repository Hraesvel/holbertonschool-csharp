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

/// <summary>
/// Constructor for class Rectangle
/// </summary>
class Rectangle : Shape {
    private int width;
    private int height;

    public int Width {
        
        get { return width;}
        set { 
            if (value < 0 )
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height {
        get {return height;}
        set { 
            if (value < 0 )
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

/// <summary>
/// Calculate area
/// </summary>
/// <returns>Int of Height * Width</returns>
    public override int Area() {
            return height * width;
    }

/// <summary>
/// Return string representation for Rectangle 
/// </summary>
/// <returns>stinrg</returns>
    public override string ToString() {
            return $"[Rectangle] {width} / {height}";
    }
}


/// <summary>
/// Constructor for class Square
/// </summary>
class Square : Rectangle {
        private int size;

        public int Size {
                get { return size;}
                set { if (value < 0)
                        throw new ArgumentException("Size must be greater than or equal to 0");
                        Width = Height = size = value;
                }
        }

        public override string ToString() {
                return $"[Square] {Size} / {Size}";
        }

}
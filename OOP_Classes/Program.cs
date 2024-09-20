// See https://aka.ms/new-console-template for more information


var rectangle1 = new Rectangle(5, 10);

Console.WriteLine("Width is " + rectangle1.Width);
rectangle1.Width = 15;
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());


class Rectangle
{
    

    public Rectangle(int width, int height)
    {
        Width = GetLenghtOrDefault(width, nameof(Width));
        _height = GetLenghtOrDefault(height, nameof(_height));
    }


   public int Width { get; private set; }

    private int _height;
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (_height > 0)
        {
            _height = value;
        }
    }

    private int GetLenghtOrDefault(int length, string name)
    {
        const int DefaultValueIfNotPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return DefaultValueIfNotPositive;
        }
        return length;
    }
    public int CalculateArea()
    {
        return Width * _height;
    }
    public int CalculateCircumference() => 2 * Width + 2 * _height;



}


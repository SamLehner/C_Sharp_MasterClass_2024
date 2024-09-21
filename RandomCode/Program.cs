// See https://aka.ms/new-console-template for more information


//var number = 0;

//while (number < 10)
//{
//    //number = number + 1;
//    //number += 1;
//    number++;
//    Console.WriteLine("Number is: " + number);
//}


//Adding the sum of the array
//int[] numbers = new int[] { 2, 6, 1, 6, 19};

//var sum = 0;
//for(int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine("Sum of elements is " + sum);



//Console.WriteLine("The loop is finished");

//Two dimensional array
//char[,] letters = new char[2, 3];

//letters[0,0] = 'a';
//letters[0,1] = 'b';
//letters[0,2] = 'c';
//letters[1,0] = 'd';
//letters[1,1] = 'e';
//letters[1,2] = 'f';

//var height = letters.GetLength(0);
//var width = letters.GetLength(1);
//Console.WriteLine("Height is " + height);
//Console.WriteLine("Width is " + width);
//for (var i = 0; i < height; i++)
//{
//    Console.WriteLine("i is " + i);
//    for (var j = 0; j < width; j++)
//    {
//        Console.WriteLine("j is " +j);
//        Console.WriteLine("element is " + letters[i,j]);
//    }
//}

//Also written like this

//var leters2 = new char[,]
//{
//    { 'a', 'b', 'c' },
//    { 'd', 'e', 'f'},
//};


//var words = new[] { "one","two","three","four"};

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}



//var words = new List<string>
//{
//    "one",
//    "two",
//};

//var moreWords = new[]
//{
//    "three",
//    "four",
//    "five",
//};
//words.AddRange(moreWords);
//Console.WriteLine("INdex of element 'four' is " + words.IndexOf("four"));

//Console.WriteLine("Count of elements is " + words.Count);

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine();
//Console.WriteLine("Removing an Item");
//words.Remove("two");

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.ReadKey();


//var internationalPizzaDay23 = new DateTime(2023, 2, 9);
//Console.WriteLine("year is " + internationalPizzaDay23.Year);
//Console.WriteLine("month is " + internationalPizzaDay23.Month);
//Console.WriteLine("day is " + internationalPizzaDay23.Day);
//Console.WriteLine("day of the week is " + internationalPizzaDay23.DayOfWeek);


//using System.Drawing;
//using System.Xml.Serialization;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//var rectangle1 = new Rectangle(5,10);
//var calculator = new ShapesMeasurementsCalculator();
//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.Height);
//Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));
//Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));

//Console.ReadKey();


//class Rectangle
//{
//    public int Height;
//    public int Width;

//    public Rectangle(int width, int height)
//    {
//        Width = GetLenghtOrDefault(width, nameof(Width));
//        Height = GetLenghtOrDefault(height, nameof(Height));
//    }

//    private int GetLenghtOrDefault(int length, string name)
//    {
//        int defaultValueIfNotPositive = 1;
//        if (length <= 0)
//        {
//            Console.WriteLine($"{name} must be a positive number.");
//            return  defaultValueIfNotPositive;
//        }
//        return length;
//    }
//    public int CalculateArea()
//    {
//        return Width * Height;
//    }
//    public int CalculateCircumference() => 2 * Width + 2 * Height;



//}

//class ShapesMeasurementsCalculator
//{
//    public int CalculateRectangleCircumference(Rectangle rectangle)
//    {
//        return 2 * rectangle.Width + 2 * rectangle.Height;
//    }

//    public int CalculateRectangleArea(Rectangle rectangle)
//    {
//        return rectangle.Width * rectangle.Height;
//    }
//}

//class MedicalAppointmentPrinter 
//{
//    public void Print(MedicalAppointment medicalAppointment)
//    {
//        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
//    }


//}



//class MedicalAppointment 
//{
//    private string _patientName;
//    private DateTime _date;

//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    //Constructor for only a name provided with date set out to one week by default if left.
//    //Calling on the constructor below using the parameters patientName and 7 to do that code before.
//    public MedicalAppointment(string patientName) : 
//        this(patientName, 7)
//    {

//    }
//    public MedicalAppointment(string patientName, int daysFromNow)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }

//    public DateTime GetDate() => _date;

//    public void Reschedule(DateTime date)
//    {
//        _date = date;
//    }

//    public void Reschedule(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void AddMonthsToReschedule(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd); 
//    }


//}

using Names_SingelResponsibilityPrinciple.DataAccess;


Console.WriteLine($"1 + 2 is " + $"{Calculator.Add(1,2) }" );
Console.ReadKey();
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}


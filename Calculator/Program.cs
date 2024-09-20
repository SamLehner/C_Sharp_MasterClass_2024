// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number:");
var userInputOne = Console.ReadLine();
var numberOne = int.Parse(userInputOne);


Console.WriteLine("Input the second number:");
var numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd the numbers.");
Console.WriteLine("[S]ubtract the numbers.");
Console.WriteLine("[M]ultiply the numbers.");

var userSelection = Console.ReadLine();

if (userSelection == "A" || userSelection == "a")
{
    Console.WriteLine(numberOne + "+" + numberTwo + "=" + (Addition(numberOne, numberTwo)));
}
else if (userSelection == "S" || userSelection == "s")
{
    Console.WriteLine(numberOne + "-" + numberTwo + "=" + (Subtraction(numberOne, numberTwo)));
}
else if (userSelection == "M" || userSelection == "m")
{
    Console.WriteLine(numberOne + "*" + numberTwo + "=" + (Mutiplication(numberOne, numberTwo)));
}
else
{
    Console.WriteLine("Invalid Option");
}
Console.ReadKey();
Console.WriteLine("Press any key to close the calculator!");
Console.ReadKey();



int Addition(int numberOne, int numberTwo)
{
    return numberOne + numberTwo;
}

int Subtraction(int numberOne, int numberTwo)
{
    return numberOne - numberTwo;
}

int Mutiplication(int numberOne, int numberTwo)
{
    return numberOne * numberTwo;
}
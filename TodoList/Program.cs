// See https://aka.ms/new-console-template for more information

//Writing to the Console all the Commands we need
using System.ComponentModel;
using System.Runtime.CompilerServices;



Console.WriteLine("Hello!");

//Instantiating our To Do list with values of strings
var todos = new List<string>();

bool shallExit = false;
while (!shallExit)
{
    //Console lines for user choice
    Console.WriteLine();
    Console.WriteLine("Hello, Gangy what u want?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    //Reads line user inputs and assigns it variable userChoice
    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllToDos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveToDo();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}



Console.ReadKey();



void SeeAllToDos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }

}
void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }
    return true;
}

void RemoveToDo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove.");
        SeeAllToDos();
    }
    while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);

}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected Index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("The given index is not valid");
    return false;

}

static void ShowNoTodosMessage()
{
    Console.WriteLine("There are no ToDos added yet");
}
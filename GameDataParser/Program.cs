using System.Net.WebSockets;

//Catching some exceptions will refactor later for cleaner code

var userInteractor = new ConsoleUserInteraction();
var app = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFileReader());
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application has experiences an unexpected error and will have to be closed.");
    logger.Log(ex);
}
Console.ReadKey();


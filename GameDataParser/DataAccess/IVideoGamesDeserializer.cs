
public interface IVideoGamesDeserializer
{
    List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents);
}
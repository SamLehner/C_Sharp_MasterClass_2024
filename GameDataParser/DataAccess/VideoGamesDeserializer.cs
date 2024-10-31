﻿using System.Text.Json;

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {


            _userInteractor.PrintError($"JSON in {fileName} file was not in a valid format. Json Body:");

            _userInteractor.PrintError(fileContents);

            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);

        }
    }
}


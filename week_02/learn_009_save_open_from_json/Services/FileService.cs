using learn_009_save_open_from_json.Models;
using System.Collections.Generic;
using System.Diagnostics;

//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace learn_009_save_open_from_json.Services;

public class FileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;
    private readonly JsonSerializerOptions _jsonSerializerOptions;

    // JSON = JavaScript Object Notation
    public FileService(string directoryPath = "Data", string fileName = "list.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
        _jsonSerializerOptions = new JsonSerializerOptions {WriteIndented = true};
    }

    // This list is strictly for the User model
    public void SaveListToFile(List<User> list)
    // This list is dynamic, you add which Type it's going to use.
    //public void SaveListToFile<T>(List<T> list)
    {
        // EACH AND EVERY TIME WHEN YOU TRY TO CREATE, UPLOAD, SAVE OR LOAD SOMETHING! try/catch!
        try
        {
            if (!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);

            // ctrl + ., install Newtonsoft package. Works, but is slow.
            //var json = JsonConvert.SerializeObject(list);
            // ctrl + ., using System.Text.Json. Which is now part of the .NET SDK, and is more effective.
            var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    public List<User> LoadListFromFile()
    {
        // EACH AND EVERY TIME WHEN YOU TRY TO CREATE, UPLOAD, SAVE OR LOAD SOMETHING! try/catch!
        try
        {
            if (!File.Exists(_filePath))
                return [];

            var json = File.ReadAllText(_filePath);
            var list = JsonSerializer.Deserialize<List<User>>(json, _jsonSerializerOptions);
            
            // Return the list, if it's null, return an empty list.
            return list ?? [];
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            // Return an empty list.
            return [];
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ListShuffling
{
    public class JsonFileHandler : IFileHandler
    {
        public (List<string>, List<string>) ReadListsFromFileToTupleOfArrays(string filePath)
        {
            try
            {
                using var sr = new StreamReader(filePath);
                var listOfStrings = JsonConvert.DeserializeObject<List<List<string>>>(sr.ReadToEnd());
                if (listOfStrings.Count >= 2)
                {
                    return (listOfStrings[0], listOfStrings[1]);
                }

                Console.WriteLine("File has less than 2 lists!");
                throw new ArgumentException("File has less than 2 lists!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found in path {filePath}!");
                throw new ArgumentException("Invalid file path!");
            }
            catch (JsonReaderException)
            {
               Console.WriteLine("Passed path is not a valid json file!");
                throw new ArgumentException("File is not a valid JSON file!");
            }
        }

        public void WriteShuffledListsToFile(string filePath, List<string> shuffledList)
        {
            JsonSerializer serializer = new JsonSerializer();
            using var sw = new StreamWriter(filePath);
            serializer.Serialize(sw, shuffledList);
        }
    }
}
using System;
using System.Collections.Generic;

namespace ListShuffling
{
    public class Shuffler
    {
        private readonly IFileHandler _fileHandler;
        private readonly IConfig _config;

        public Shuffler(IConfig config)
        {
            _config = config;
            var fileHandlerFactory = new FileHandlerFactory();
            if (Enum.TryParse<FileTypeEnum>(_config.FileNames.FileType, out var fileType))
            {
                _fileHandler = fileHandlerFactory.CreateFileHandler(fileType);
            }
            else
            {
                throw new ArgumentException("Invalid file type!");
            }
        }

        public List<string> GetShuffledListFromFile()
        {
            var listsTuple = _fileHandler.ReadListsFromFileToTupleOfArrays(_config.FileNames.InputFileName);
            List<string> shuffled;
            if (_config.ShuffleType.OneByOneShuffle)
            {
                shuffled = listsTuple.ShuffleOneByOne();
            }
            else if (_config.ShuffleType.RandomShuffle)
            {
                shuffled = listsTuple.RandomShuffle();
            }
            else
            {
                throw new ArgumentException("No shuffle type chosen!");
            }

            return shuffled;
        }

        public void SaveShuffledListToFile(List<string> shuffledList)
        {
            _fileHandler.WriteShuffledListsToFile(_config.FileNames.OutputFileName, shuffledList);
        }
    }
}
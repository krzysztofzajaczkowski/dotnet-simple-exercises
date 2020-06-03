using System.Collections.Generic;

namespace ListShuffling
{
    public interface IFileHandler
    {
        public (List<string>, List<string>) ReadListsFromFileToTupleOfArrays(string filePath);

        public void WriteShuffledListsToFile(string filePath, List<string> shuffledList);
    }
}
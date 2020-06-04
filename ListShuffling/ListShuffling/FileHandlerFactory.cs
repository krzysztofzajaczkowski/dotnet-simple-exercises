namespace ListShuffling
{
    public class FileHandlerFactory
    {
        public IFileHandler CreateFileHandler(FileTypeEnum fileType)
        {
            IFileHandler fileHandler = null;
            if (fileType == FileTypeEnum.JSON)
            {
                fileHandler = new JsonFileHandler();
            }

            if (fileType == FileTypeEnum.CSV || fileType == FileTypeEnum.TXT)
            {
                fileHandler = new CsvFileHandler();
            }

            return fileHandler;
        }
    }
}
namespace FileAlphanumericCounter
{
    public class FilesConfig : IFilesConfig
    {
        public string[] AllowedExtensions { get; set; }
        public string RegexPattern { get; set; }
    }
}